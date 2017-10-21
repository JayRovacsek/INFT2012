using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            Random rDieRand = new Random();                     // Roll some die via Math.Random class

            for (int i = 0; i < iNumDieRolled; i++)             // Create 5 rolls between 1 - 6
            {
                iDieRolls[i] = rDieRand.Next(1, 7);
            }

            RerollDieByChoice(iDieRolls, sPlayerName, bAIPresent, iScoreTarget, iCurrentScore);     // Check if the users want to reroll, including AI

            determineScore(iDieRolls, iNumDieRolled);                                               // Determine the score after re-rolls occur

        }

        private void RerollDieByChoice(int[] iDieRolls, string sPlayerName, bool bAIPresent, int iScoreTarget, int iCurrentScore)
        {
            bool bSkipped = false;                                          // Bool to check if the user skips rerolling at all, if they do we can assume they 
            frmRerollOptions RerollOptions = new frmRerollOptions();        // Won't want to be asked about a reroll a scecond time
            Array.Sort(iDieRolls);                                          // Sort dice before drawing labels on the form about to pop up

            if (bAIPresent && sPlayerName == "Evil Robot AI")                                       // If the user is an AI
            {
                AI AITurn = new AI();                                                               // Create AI class
                bool[] bRerolledDie = AITurn.performAITurn(iDieRolls, iScoreTarget, iCurrentScore); // Create array same size as dice, ture = reroll, else leave
                queryDieRolls = RerollOptions.DieRerollAI(iDieRolls, bRerolledDie);                 // Set the dice via public method here
                bRerolledDie = AITurn.performAITurn(iDieRolls, iScoreTarget, iCurrentScore);        // Reroll again for AI
                queryDieRolls = RerollOptions.DieRerollAI(iDieRolls, bRerolledDie);                 // Set die again
            }
            else
            {
                RerollOptions.RelabelOptions(iDieRolls, sPlayerName);                               // Else if user is a player, show the form
                RerollOptions.ShowDialog();
                bSkipped = RerollOptions.Skipped();     
                queryDieRolls = RerollOptions.DieReroll(iDieRolls);                                 // Reroll based on user input
                if (bSkipped)                                                                       // If they rerolled, allow another reroll opportunity
                {
                    frmRerollOptions RerollOptionsTwo = new frmRerollOptions();                     // Create a second instance of form, relabel etc etc
                    RerollOptionsTwo.RelabelOptions(iDieRolls, sPlayerName);
                    RerollOptionsTwo.ShowDialog();
                    queryDieRolls = RerollOptionsTwo.DieReroll(iDieRolls);                          // Set dice based on user input
                }
            }
        }
           
        private void determineScore(int[] iDieRolls, int iNumDieRolled)                             // Determine score method
        {
            scoreQuery = 0;                                                                         // Set turn score
            Array.Sort(iDieRolls);                                                                  // Sort the dice
            int iProposedScoreA = 0;                                                                // If we can score off both sequence and duplicates, we need to know
            int iProposedScoreB = 0;
            int iModDieTotal = 0;                                                                   // Modulus of die total to determine if score is added or subtracted

            if (sequenceCheck(iDieRolls,iNumDieRolled))                                             // If a sequence exists score it
            {
                int iNumberOfSequential = sequenceCount(iDieRolls);
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
            if (duplicatesCheck(iDieRolls, iNumDieRolled))                                          // If duplicates exist, score them 
            {
                int iNumberOfDuplicate = duplicateCount(iDieRolls);
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

            int iTotalDieRoll = totalDieRoll(iDieRolls);                             // Modulo the score to determine score added or removed
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

            scoreUpdate(iProposedScoreA, iProposedScoreB, iModDieTotal);                            // Update the score, taking the highest value
        }

        private bool sequenceCheck(int[] iDieRolls, int iNumDieRolled)  
        {
            int iCountSequential = 1;

            for (int i = 0; i < iNumDieRolled - 1; i++)                             // Iterate through the dice rolls, find sequential
            {
                if (iDieRolls[i] + 1 == iDieRolls[i + 1] && iDieRolls[i] != 6)      // If the current index is equal to the next + 1 we can assume sequential
                {                                                                   // However we also need to avoid caring about the current index if it as a 6
                    iCountSequential++;
                    if(iCountSequential >= 3)
                    {
                        return true;
                    }
                }
                else if (iDieRolls[i] == iDieRolls[i + 1] && iDieRolls[i] != 6)     // Skip instances such as 1,2,2,3,4 which 2 would destroy a proper check for sequence
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

        private int sequenceCount(int[] iDieRolls)               // Count sequences
        {
            int iCountSequential = 1;
            int iCountSequentialMax = 1;

            for (int i = 0; i < 5 - 1; i++)                             // Iterate through the dice rolls, find sequential
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

            if(iCountSequential < iCountSequentialMax)
            {
                return iCountSequentialMax;
            }
            else
            {
                return iCountSequential;
            }
        }

        private bool duplicatesCheck(int[] iDieRolls, int iNumDieRolled)            // Check if duplicates exist
        {
            int iDuplicatesCount = 1;

            for (int i = 0; i < iNumDieRolled - 1; i++)                       
            {
                if (iDieRolls[i] == iDieRolls[i + 1])                               // If it is equal to the next index, duplicates found
                {
                    iDuplicatesCount++;
                    if (iDuplicatesCount >= 3)                                      // More than 3 of the same number, return true and count later
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

        private int duplicateCount(int[] iDieRolls)              // Count number of duplicates
        {
            int iCountDuplicate = 1;
            int iMaxCountDuplicate = 1;

            for (int i = 0; i < 5 -1; i++)                              // Check all dice.
            {
                if (iDieRolls[i] == iDieRolls[i + 1])                   // Increment count if duplicates found
                {
                    iCountDuplicate++;
                }
                else
                {
                    if(iCountDuplicate > iMaxCountDuplicate)            // If we failed to find a duplicate, we need to assume that more may exist
                    {
                        iMaxCountDuplicate = iCountDuplicate;           // Set a max and reset count to 1
                    }
                    iCountDuplicate = 1;
                }
                if (iCountDuplicate > iMaxCountDuplicate)               // If the first bunch of duplicates are greater in number, we want that number
                {
                    iMaxCountDuplicate = iCountDuplicate;
                }
            }
            return iMaxCountDuplicate;                                  // Return the max count of duplicates
        }

        private int totalDieRoll(int[] iDieRolls)                       // Figure the total roll count of all dice.
        {
            int iTotalDie = 0;

            for (int i = 0; i < 5; i++)
            {
                iTotalDie = iTotalDie + iDieRolls[i];
            }

            return iTotalDie;
        }

        private void scoreUpdate(int iProposedScoreA, int iProposedScoreB, int iModRolls)   // Update score
        {
            int iScoreForRound = 0;

            if (iProposedScoreA > iProposedScoreB)                                          // Determine if duplicate or seq score was larger
            {
                iScoreForRound = iProposedScoreA;
            }
            else
            {
                iScoreForRound = iProposedScoreB;
            }

            if(iModRolls == 1)                                                              // If total is an odd number, minus the score
            {
                scoreQuery = scoreQuery - iScoreForRound;
            }
            else
            {
                scoreQuery = iScoreForRound;                                                // Otherwise add it
            }
        }

        #endregion
    }
}