using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INFT2012Assignment
{
    class Turn
    {
        #region Pub Methods & related vars for data hiding.

        private int[] iDieRolls = new int[5];

        private int scoreAmount;    //Setup a variable to hold scoreAmount

        public int scoreQuery      //Setup a method to query the score of a turn
        {
            get
            {
                return scoreAmount;
            }
            set
            {
                scoreAmount = value;
            }
        }

        public int[] queryDieRolls      //Setup a method to query the score of a turn
        {
            get
            {
                return iDieRolls;
            }
            set
            {
                iDieRolls = value;
            }
        }

        #endregion

        #region Methods for performing turn

        public void performTurn(int iNumDieRolled, string sPlayerName, bool bAIPresent, int iScoreTarget, int iCurrentScore)
        {

            Random rDieRand = new Random();

            for (int i = 0; i < iNumDieRolled; i++)
            {
                iDieRolls[i] = rDieRand.Next(1, 7);
            }

            RerollDieByChoice(iDieRolls, sPlayerName, bAIPresent, iScoreTarget, iCurrentScore);

            determineScore(iDieRolls, iNumDieRolled);

            string sRolls = "Rolled: ";
            int iMaxDie = 5;

            for (int i = iMaxDie - iNumDieRolled; i < iMaxDie; i++)
            {
                if (i == iMaxDie - 1)
                {
                    sRolls += Convert.ToString(iDieRolls[i]);
                }
                else
                {
                    sRolls += Convert.ToString(iDieRolls[i] + ", ");
                }
            }

            MessageBox.Show(sRolls, "");

        }

        private void RerollDieByChoice(int[] iDieRolls, string sPlayerName, bool bAIPresent, int iScoreTarget, int iCurrentScore)
        {
            bool bSkipped = false;
            frmRerollOptions RerollOptions = new frmRerollOptions();

            string sRolls = "Rolled: ";
            int iMaxDie = 5;

            for (int i = 0; i < 5; i++)
            {
                if (i == 4)
                {
                    sRolls += Convert.ToString(iDieRolls[i]);
                }
                else
                {
                    sRolls += Convert.ToString(iDieRolls[i] + ", ");
                }
            }

            MessageBox.Show(sRolls, "");


            if (bAIPresent && sPlayerName == "Evil Robot AI")
            {
                AI AITurn = new AI();
                bool[] bRerolledDie = AITurn.performAITurn(iDieRolls, iScoreTarget, iCurrentScore);
                queryDieRolls = RerollOptions.DieRerollAI(iDieRolls, bRerolledDie);
                bRerolledDie = AITurn.performAITurn(iDieRolls, iScoreTarget, iCurrentScore);
                queryDieRolls = RerollOptions.DieRerollAI(iDieRolls, bRerolledDie);
            }
            else
            {
                RerollOptions.RelabelOptions(iDieRolls, sPlayerName);
                RerollOptions.ShowDialog();
                bSkipped = RerollOptions.Skipped();
                queryDieRolls = RerollOptions.DieReroll(iDieRolls);
                if (bSkipped)
                {
                    frmRerollOptions RerollOptionsTwo = new frmRerollOptions();
                    RerollOptionsTwo.RelabelOptions(iDieRolls, sPlayerName);
                    RerollOptionsTwo.ShowDialog();
                    queryDieRolls = RerollOptionsTwo.DieReroll(iDieRolls);
                }
            }
        }
           


        private void determineScore(int[] iDieRolls, int iNumDieRolled)
        {
            scoreQuery = 0;
            Array.Sort(iDieRolls);
            int iProposedScoreA = 0;
            int iProposedScoreB = 0;
            int iModDieTotal = 0;

            if (sequenceCheck(iDieRolls,iNumDieRolled))
            {
                int iNumberOfSequential = sequenceCount(iDieRolls, iNumDieRolled);
                switch (iNumberOfSequential)
                {
                    case 3:
                        iProposedScoreA = 5;
                        break;
                    case 4:
                        iProposedScoreA = 15;
                        break;
                    case 5:
                        iProposedScoreA = 25;
                        break;
                }
            }
            if (duplicatesCheck(iDieRolls, iNumDieRolled))
            {
                int iNumberOfDuplicate = duplicateCount(iDieRolls, iNumDieRolled);
                switch (iNumberOfDuplicate)
                {
                    case 3:
                        iProposedScoreB = 10;
                        break;
                    case 4:
                        iProposedScoreB = 20;
                        break;
                    case 5:
                        iProposedScoreB = 30;
                        break;
                }

            }

            int iTotalDieRoll = totalDieRoll(iDieRolls, iNumDieRolled);
            iModDieTotal = iTotalDieRoll % 2;

            switch (iModDieTotal)
            {
                case 0:
                    iModDieTotal = 0;
                    break;
                case 1:
                    iModDieTotal = 1;
                    break;
            }

            scoreUpdate(iProposedScoreA, iProposedScoreB, iModDieTotal);
        }

        private bool sequenceCheck(int[] iDieRolls, int iNumDieRolled)
        {
            int iCountSequential = 1;

            for (int i = 0; i < iNumDieRolled - 1; i++)                         //for (int i = 0; i < iNumDieRolled - 1; i++)
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)
                {
                    iCountSequential++;
                    if(iCountSequential >= 3)
                    {
                        return true;
                    }
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 6)
                    {
                    //You know nothing Jon Snow.
                }
                else
                {
                    iCountSequential = 1;
                }
            }

            return false;
        }

        private int sequenceCount(int[] iDieRolls, int iNumDieRolled)
        {
            int iCountSequential = 1;
            int iCountSequentialMax = 1;

            for (int i = 0; i < iNumDieRolled - 1; i++)
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)
                {
                    iCountSequential++;
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 6)
                {
                    //You know nothing Jon Snow.
                }
                else
                {
                    iCountSequentialMax = iCountSequential;
                    iCountSequential = 1;
                }
            }

            if(iCountSequential < iCountSequentialMax)
            {
                return iCountSequentialMax;
            }
            else
            {
                return iCountSequential;
            }
        }

        private bool duplicatesCheck(int[] iDieRolls, int iNumDieRolled)
        {
            int iDuplicatesCount = 1;

            for (int i = 0; i < iNumDieRolled - 1; i++)                         //for (int i = 0; i < iNumDieRolled - 1; i++)
            {
                if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 0)
                {
                    iDuplicatesCount++;
                    if (iDuplicatesCount >= 3)
                    {
                        return true;
                    }
                }
                else
                {
                    iDuplicatesCount = 1;
                }
            }
            return false;
        }

        private int duplicateCount(int[] iDieRolls, int iNumDieRolled)
        {
            int iCountDuplicate = 1;
            int iMaxCountDuplicate = 1;

            for (int i = 0; i < iNumDieRolled -1; i++)
            {
                if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 0)
                {
                    iCountDuplicate++;
                }
                else
                {
                    if(iCountDuplicate > iMaxCountDuplicate)
                    {
                        iMaxCountDuplicate = iCountDuplicate;
                    }
                    iCountDuplicate = 1;
                }
                if (iCountDuplicate > iMaxCountDuplicate)
                {
                    iMaxCountDuplicate = iCountDuplicate;
                }
            }
            return iMaxCountDuplicate;
        }

        private int totalDieRoll(int[] iDieRolls, int iNumDieRolled)
        {
            int iTotalDie = 0;

            for (int i = 0; i < 5; i++)
            {
                iTotalDie = iTotalDie + iDieRolls[i];
            }

            return iTotalDie;
        }

        private void scoreUpdate(int iProposedScoreA, int iProposedScoreB, int iModRolls)
        {
            int iScoreForRound = 0;

            if (iProposedScoreA > iProposedScoreB)
            {
                iScoreForRound = iProposedScoreA;
            }
            else
            {
                iScoreForRound = iProposedScoreB;
            }

            if(iModRolls == 1)
            {
                scoreQuery = scoreQuery - iScoreForRound;
            }
            else
            {
                scoreQuery = iScoreForRound;
            }
        }

        #endregion
    }
}