using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFT2012Assignment
{
    class AI
    {
        public bool[] performAITurn(int[] iDieRolls, int iScoreTarget, int iCurrentScore)
        {
            Array.Sort(iDieRolls);
            int iScoreDifference = 0;
            int iSequentialDie = 0;
            int iDuplicateDie = 0;
            bool[] bRerolledDie = new bool[5];

            if (sequenceCheck(iDieRolls))
            {
                iSequentialDie = sequenceCount(iDieRolls);
            }

            if (duplicatesCheck(iDieRolls))
            {
                iDuplicateDie = duplicateCount(iDieRolls);
            }

            if (iCurrentScore < 0)
            {
                iCurrentScore = iCurrentScore * -1;
                iScoreDifference = iScoreTarget + iCurrentScore;
            }
            else
            {
                iScoreDifference = iScoreTarget - iCurrentScore;
            }
            // Prefer all the same for larger scores
            // of a kind = 10, 20, 30
            // Seq = 5, 15, 25

            if (iScoreDifference > 30)
            {
                if (iSequentialDie != 0)                            // Prefer the potential average which is more suited to the current setting
                {
                    // figure the dice to reroll that aint dupes here
                }
                else if (iDuplicateDie != 0)
                {
                    // figure what dice exist in a sequence here
                }
                else
                {
                    for (int i = 0; i < 5 - 1; i++)
                    {
                        bRerolledDie[i] = true;
                    }
                }
            }
            else if(iScoreDifference > 15)
            {
                if (iDuplicateDie != 0)
                {
                    // figure the dice to reroll that aint dupes here
                }
                else if (iSequentialDie != 0)
                {
                    // figure what dice exist in a sequence here
                }
                else
                {
                    for (int i = 0; i < 5 - 1; i++)
                    {
                        bRerolledDie[i] = true;
                    }
                }
            }

            return bRerolledDie;
        }

        private bool sequenceCheck(int[] iDieRolls)
        {
            int iCountSequential = 1;

            for (int i = 0; i < 5 - 1; i++)             
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)
                {
                    iCountSequential++;
                    if (iCountSequential >= 2)
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

        private int sequenceCount(int[] iDieRolls)
        {
            int iCountSequential = 1;
            int iCountSequentialMax = 1;

            for (int i = 0; i < 5 - 1; i++)
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

            if (iCountSequential < iCountSequentialMax)
            {
                return iCountSequentialMax;
            }
            else
            {
                return iCountSequential;
            }
        }

        private bool duplicatesCheck(int[] iDieRolls)
        {
            int iDuplicatesCount = 1;

            for (int i = 0; i < 5 - 1; i++)                         //for (int i = 0; i < iNumDieRolled - 1; i++)
            {
                if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 0)
                {
                    iDuplicatesCount++;
                    if (iDuplicatesCount >= 2)
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

        private int duplicateCount(int[] iDieRolls)
        {
            int iCountDuplicate = 1;
            int iMaxCountDuplicate = 1;

            for (int i = 0; i < 5 - 1; i++)
            {
                if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 0)
                {
                    iCountDuplicate++;
                }
                else
                {
                    if (iCountDuplicate > iMaxCountDuplicate)
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
    }
}
