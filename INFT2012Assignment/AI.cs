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
            int iScoreDifference = 0;                                   // Variables we will need to make decisions
            int iSequentialDie = 0;
            int iDuplicateDie = 0;
            bool[] bRerolledDie = new bool[5];                          

            if (sequenceCheck(iDieRolls))                               // If sequential patterns exist, count them
            {
                iSequentialDie = sequenceCount(iDieRolls);
            }

            if (duplicatesCheck(iDieRolls))                             // If duplicates exist, count them also
            {
                iDuplicateDie = duplicateCount(iDieRolls);
            }

            if (iCurrentScore < 0)                                      // Determine the amount of score left
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

            if (iDuplicateDie != 0)                                     // If duplicates exist, start looking at what dice AI should re-roll
            {
                if(iDuplicateDie > iSequentialDie)                      // If the number of duplicates outweigh the sequentials, prefer the duplicates
                {
                    bRerolledDie = selectNonDuplicates(bRerolledDie, iDieRolls);
                }
                else                                                    // If duplicates did not exist, we can assume sequetials may
                {
                    bRerolledDie = selectNonSequential(bRerolledDie, iDieRolls);
                }
            }
            else if (iSequentialDie != 0)                               // If no duplicates existed, however a sequential does, let's handle that
            {
                bRerolledDie = selectNonSequential(bRerolledDie, iDieRolls);
            }
            else                                                        // If neither duplicates or sequential numbers appear, we should instead reroll all numbers
            {
                for (int i = 0; i < 5 - 1; i++)
                {
                    bRerolledDie[i] = true;
                }
            }

            return bRerolledDie;                                        // Return our reroll choices
        }

        private bool[] selectNonSequential(bool[] bRerolledDie, int[] iDieRolls)
        {
            int iCountSequential = 1;                                               // Set a sequential count, the max count we encounter and the start of the max sequential array
            int iCountSequentialMax = 1;
            int iCountSeqentialStart = 0;

            for (int i = 0; i < 5 - 1; i++)
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)
                {
                    if(iCountSequential == 1)
                    {
                        iCountSeqentialStart = i;                                   // We found the start to a sequential 
                    }
                    iCountSequential++;                                             // Increase count
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 6)
                {
                    //You know nothing Jon Snow. - Skipping potential sequentail doubles such as: 1,2,2,3,6 which looking at 2,2 would break this.
                }
                else
                {
                    iCountSequentialMax = iCountSequential;                         // If we've got to the end of a sequential bunch, reset count and 
                    iCountSequential = 1;                                           // set max count into a variable
                }
            }

            for(int i = 0; i < 5 + 1; i++)                                                          // Once we know the start of a sequential bunch
            {
                if(i >= iCountSeqentialStart && i < (iCountSeqentialStart + iCountSequentialMax))   // We also know the number of occurances
                {
                    bRerolledDie[i] = true;                                                         // Flag any index that isn't within the bounds we want
                }
            }

            return bRerolledDie;                                                                    // Return the die choice which are not part of the max sequence
        }

        private bool[] selectNonDuplicates(bool[] bRerolledDie, int[] iDieRolls)
        {
            int[] iCount = new int[6];
            int iMaxCount = 0;
            for (int i = 0; i < 6 - 1; i++)                     // Count each number of the number of rolls present
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
                    iMaxCount = i + 1;                  // Find the number with the max count
                }
            }
            for (int i = 0; i < 5; i++)
            {
                if (iDieRolls[i] != iMaxCount)           // Set all number other than the max duplicate as to be rerolled
                {
                    bRerolledDie[i] = true;
                }
            }
            return bRerolledDie;                        // Return the die choice which are not part of duplicates
        }

        private bool sequenceCheck(int[] iDieRolls)
        {
            int iCountSequential = 1;

            for (int i = 0; i < 5 - 1; i++)                                     // Iterate through the dice rolls, find sequential
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)  // If the current index is equal to the next + 1 we can assume sequential
                {                                                               // However we also need to avoid caring about the current index if it as a 6
                    iCountSequential++;                                         
                    if (iCountSequential >= 2)
                    {
                        return true;
                    }
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 6) // Skip instances such as 1,2,2,3,4 which 2 would destroy a proper check for sequence
                {
                    //You know nothing Jon Snow.
                }
                else
                {
                    iCountSequential = 1;                                       // Otherwise we can assume there may be multiple sequence of length 2
                }
            }

            return false;
        }

        private int sequenceCount(int[] iDieRolls)                                  // Count sequences
        {
            int iCountSequential = 1;                                               
            int iCountSequentialMax = 1;

            for (int i = 0; i < 5 - 1; i++)                                         // Iterate through the dice rolls, find sequential
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)      // If the current index is equal to the next + 1 we can assume sequential
                {                                                                   // However we also need to avoid caring about the current index if it as a 6
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

        private bool duplicatesCheck(int[] iDieRolls)               // Check if duplicates exist
        {
            int iDuplicatesCount = 1;

            for (int i = 0; i < 5 - 1; i++)                         
            {
                if (iDieRolls[i] == iDieRolls[i + 1])               // If it is equal to the next index, duplicates found
                {
                    iDuplicatesCount++;
                    if (iDuplicatesCount >= 2)                      // More than 2 of the same number, return true and count later
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private int duplicateCount(int[] iDieRolls)                         // Count number of duplicates
        {
            int iCountDuplicate = 1;
            int iMaxCountDuplicate = 1;

            for (int i = 0; i < 5 - 1; i++)                                 // Check all dice.
            {
                if (iDieRolls[i] == iDieRolls[i + 1])                       // Increment count if duplicates found
                {
                    iCountDuplicate++;
                }
                else
                {
                    if (iCountDuplicate > iMaxCountDuplicate)               // If we failed to find a duplicate, we need to assume that more may exist
                    {
                        iMaxCountDuplicate = iCountDuplicate;               // Set a max and reset count to 1
                    }
                    iCountDuplicate = 1;
                }
                if (iCountDuplicate > iMaxCountDuplicate)                   // If the first bunch of duplicates are greater in number, we want that number
                {
                    iMaxCountDuplicate = iCountDuplicate;
                }
            }
            return iMaxCountDuplicate;                                      // Return the max count of duplicates
        }
    }
}
