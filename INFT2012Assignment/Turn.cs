using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Array.Sort(iDieRolls);

            if (sequenceCheck(iDieRolls,iNumDieRolled))
            {
                int iNumberOfSequential = sequenceCount(iDieRolls, iNumDieRolled);
                switch (iNumberOfSequential)
                {
                    case 3:
                        scoreQuery = 5;
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                }
            }

        }

        private bool sequenceCheck(int[] iDieRolls, int iNumDieRolled)
        {
            int iCountSequential = 1;

            for (int i = 0; i < iNumDieRolled; i++)
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && (iDieRolls[i] != 6))
                {
                    iCountSequential++;
                    if(iCountSequential >= 3)
                    {
                        return true;
                    }
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && (iDieRolls[i] != 6))
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

            for (int i = 0; i < iNumDieRolled; i++)
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && (iDieRolls[i] != 6))
                {
                    iCountSequential++;
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && (iDieRolls[i] != 6))
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
