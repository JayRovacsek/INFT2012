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
        private int[] iDieRolls = new int[5];

        private List<int> lDieRolls = new List<int>();

        public void performTurn(int iNumDieRolled)
        {
            Random rDieRand = new Random();

            for (int i = 0; i < iNumDieRolled; i++)
            {
                iDieRolls[i] = rDieRand.Next(1, 7);     //KILL ME LATER
            }

            List<int> lDieRolls = new List<int>();

            for (int i = 0; i < iNumDieRolled; i++)
            {
                lDieRolls.Add(rDieRand.Next(1, 7));

            }

            determineScore(iDieRolls, lDieRolls, iNumDieRolled);
        }

        //public Turn()
        //{
        //    Random rDieRand = new Random();
        //    List<int> dickRolls = new List<int>();

        //    for (int i = 0; i < 5; i++)
        //    {
        //        dickRolls.Add(rDieRand.Next(1, 7));
        //    }
        //    int totalScore = 0;

        //    dickRolls.TrueForAll
        //    foreach (var item in dickRolls)
        //    {

        //        totalScore < checkSequence
        //          totalScore += checkDuplicates
        //            totalScore += CheckDicks()

        //    }
        //}

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

        public List<int> queryDieRollsList      //Setup a method to query the score of a turn
        {
            get
            {
                return lDieRolls;
            }
        }

        private void determineScore(int[] iDieRolls,List<int> lDieRolls, int iNumDieRolled)
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
            bool duplicates = false;
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
    }
}
