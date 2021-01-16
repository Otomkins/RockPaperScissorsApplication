using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors_Code
{
    public class RockPaperScissorsCode
    {
        public int player1Score;
        public int player2Score;

        public string player1Choice;
        public string player2Choice;

        public string[] choices = new string[3]
        {
            "Rock",
            "Paper",
            "Scissors"
        };

        public string DetermineWinner()
        {
            string winnerMessage = "";

            switch (DetermineOutcome())
            {
                case 1: // Player 1 Wins
                    player1Score++;
                    break;
                case 2: // Player 1 Wins
                    player1Score++;
                    break;
                case 3: // Player 1 Wins
                    player1Score++;
                    break;

                case 4:  // Player 2 Wins
                    player2Score++;
                    break;
                case 5: // Player 2 Wins
                    player2Score++;
                    break;
                case 6: // Player 2 Wins
                    player2Score++;
                    break;

                case 7:  // Draw
                    break;
                case 8:  // Draw
                    break;
                case 9: // Draw
                    break;
            }
            return winnerMessage;
        }

        private int DetermineOutcome()
        {
            // Player 1 Wins
            if (player1Choice == "Rock" && player2Choice == "Scissors") return 1;
            else if (player1Choice == "Paper" && player2Choice == "Rock") return 2;
            else if (player1Choice == "Scissors" && player2Choice == "Paper") return 3;

            // Player 2 Wins
            else if (player1Choice == "Rock" && player2Choice == "Paper") return 4;
            else if (player1Choice == "Paper" && player2Choice == "Scissors") return 5;
            else if (player1Choice == "Scissors" && player2Choice == "Rock") return 6;

            // Draw
            else if (player1Choice == "Rock" && player2Choice == "Rock") return 7;
            else if (player1Choice == "Paper" && player2Choice == "Paper") return 8;
            else return 9;
        }
    }
}
