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

        public void performTurn(string playerName, int iNumDieRolled)
        {
            Random rDieRand = new Random();

            for (int i = 0; i < iNumDieRolled; i++)
            {
                iDieRolls[i] = rDieRand.Next(1, 7);

            }

            determineScore(iDieRolls, iNumDieRolled);
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

        private void determineScore(int[] iDieRolls, int iNumDieRolled)
        {
            scoreQuery = 0;
            Array.Sort(iDieRolls);

            if (sequenceCheck(iDieRolls,iNumDieRolled))
            {
                int iNumberOfSequential = sequenceCount(iDieRolls, iNumDieRolled);
                switch (iNumberOfSequential)
                {
                    case 3:
                        scoreUpdate(5);
                        break;
                    case 4:
                        scoreUpdate(15);
                        break;
                    case 5:
                        scoreUpdate(25);
                        break;
                }
            }
            if (duplicatesCheck(iDieRolls, iNumDieRolled))
            {
                int iNumberOfDuplicate = duplicateCount(iDieRolls, iNumDieRolled);
                switch (iNumberOfDuplicate)
                {
                    case 3:
                        scoreUpdate(10);
                        break;
                    case 4:
                        scoreUpdate(20);
                        break;
                    case 5:
                        scoreUpdate(30);
                        break;
                }
            }

            int iTotalDieRoll = totalDieRoll(iDieRolls, iNumDieRolled);
            int iModTotal = iTotalDieRoll % 2;
       
            switch (iModTotal)
            {
                case 0:
                    MessageBox.Show(Convert.ToString(iTotalDieRoll), "Equal");
                    break;
                case 1:
                    MessageBox.Show(Convert.ToString(iTotalDieRoll), "Odd");
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
            MessageBox.Show(Convert.ToString(scoreQuery));

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
                    iCountSequential = 1;
                }
            }

            return iCountSequential;
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
            MessageBox.Show("Duplicate", "");

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

        private void scoreUpdate(int iProposedScore)
        {
            int iCurrentScore = scoreQuery;
            if (iProposedScore > iCurrentScore)
            {
                scoreQuery = iProposedScore;
            }
        }
    }
}
