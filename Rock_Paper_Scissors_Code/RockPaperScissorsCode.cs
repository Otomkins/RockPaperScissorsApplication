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

        public string[] choices = new string[6]
        {
            "Rock",
            "Paper",
            "Scissors",
            "Rock",
            "Paper",
            "Scissors"
        };

        public void SetPlayerChoice(int playerChoice)
        {
            if (playerChoice > 0 && playerChoice < 4)
                player1Choice = choices[playerChoice - 1];
            else
                player2Choice = choices[playerChoice - 1];
        }

        public string DetermineWinner()
        {
            string winnerMessage = "";

            switch (DetermineOutcome())
            {
                // Player 1 Wins
                case 1:
                    player1Score++;
                    winnerMessage = "Player 1 Wins! Rock Beats Scissors!";
                    break;
                case 2:
                    player1Score++;
                    winnerMessage = "Player 1 Wins! Paper Beats Rock!";
                    break;
                case 3:
                    player1Score++;
                    winnerMessage = "Player 1 Wins! Scissors Beats Paper!";
                    break;
                // Player 2 Wins
                case 4:  
                    player2Score++;
                    winnerMessage = "Player 2 Wins! Paper Beats Rock!";
                    break;
                case 5:
                    player2Score++;
                    winnerMessage = "Player 2 Wins! Scissors Beats Paper!";
                    break;
                case 6:
                    player2Score++;
                    winnerMessage = "Player 2 Wins! Rock Beats Scissors!";
                    break;
                // Draw
                case 7:
                    winnerMessage = "Draw! Both Players Selected Rock!";
                    break;
                case 8:
                    winnerMessage = "Draw! Both Players Selected Paper!";
                    break;
                case 9:
                    winnerMessage = "Draw! Both Players Selected Scissors!";
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
