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

            if (iDuplicateDie != 0)
            {
                if(iDuplicateDie > iSequentialDie)
                {
                    int[] iCount = new int[6];
                    int iMaxCount = 0;
                    for (int i = 0; i < 6 - 1; i++)
                    {
                        switch (iDieRolls[i])
                        {
                            case 1:
                                iCount[0]++;
                                break;
                            case 2:
                                iCount[1]++;
                                break;
                            case 3:
                                iCount[2]++;
                                break;
                            case 4:
                                iCount[3]++;
                                break;
                            case 5:
                                iCount[4]++;
                                break;
                            case 6:
                                iCount[5]++;
                                break;
                        }  
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        if (iCount[i] > iCount[i + 1])          // Always will prefer a lower number - possible issue
                        {
                            iMaxCount = i + 1;
                        }
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        if(iDieRolls[i] != iMaxCount)
                        {
                            bRerolledDie[i] = true;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < 5 - 1; i++)
                    {
                        if(iDieRolls[i] + 1 != iDieRolls[i + 1])
                        {
                            bRerolledDie[i] = true;
                        }
                    }
                }
            }
            else if (iSequentialDie != 0)
            {
                for (int i = 0; i < 5 - 1; i++)
                {
                    if (iDieRolls[i] + 1 != iDieRolls[i + 1])
                    {
                        bRerolledDie[i] = true;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 5 - 1; i++)
                {
                    bRerolledDie[i] = true;
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
