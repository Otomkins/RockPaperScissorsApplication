using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors_Code
{
    public class RockPaperScissorsService
    {
        private int _player1Score;
        private int _player2Score;

        private string _player1Choice;
        private string _player2Choice;

        private readonly string[] _choices = new string[6]
        {
            "Rock",
            "Paper",
            "Scissors",
            "Rock",
            "Paper",
            "Scissors"
        };

        public int RetrievePlayer1Score() => _player1Score;
        public int RetrievePlayer2Score() => _player2Score;
        public string RetrievePlayer1Choice() => _player1Choice;
        public string RetrievePlayer2Choice() => _player2Choice;

        public void SetPlayerChoice(int playerChoice)
        {
            if (playerChoice > 0 && playerChoice < 4)
                _player1Choice = _choices[playerChoice - 1];
            else // Added for potential multiplayer in the future. Player 2 would pass through 4, 5 or 6 for their choice
                _player2Choice = _choices[playerChoice - 1];
        }

        public string DetermineWinner()
        {
            string winnerMessage = "";

            var rand = new Random();
            SetPlayerChoice(rand.Next(4, 7)); // Randomly selects a Player 2 response

            switch (DetermineOutcome())
            {
                // Player 1 Wins
                case 1:
                    _player1Score++;
                    winnerMessage = "Player 1 Wins! Rock Beats Scissors!";
                    break;
                case 2:
                    _player1Score++;
                    winnerMessage = "Player 1 Wins! Paper Beats Rock!";
                    break;
                case 3:
                    _player1Score++;
                    winnerMessage = "Player 1 Wins! Scissors Beats Paper!";
                    break;
                // Player 2 Wins
                case 4:
                    _player2Score++;
                    winnerMessage = "Player 2 Wins! Paper Beats Rock!";
                    break;
                case 5:
                    _player2Score++;
                    winnerMessage = "Player 2 Wins! Scissors Beats Paper!";
                    break;
                case 6:
                    _player2Score++;
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
            if (_player1Choice == "Rock" && _player2Choice == "Scissors") return 1;
            else if (_player1Choice == "Paper" && _player2Choice == "Rock") return 2;
            else if (_player1Choice == "Scissors" && _player2Choice == "Paper") return 3;

            // Player 2 Wins
            else if (_player1Choice == "Rock" && _player2Choice == "Paper") return 4;
            else if (_player1Choice == "Paper" && _player2Choice == "Scissors") return 5;
            else if (_player1Choice == "Scissors" && _player2Choice == "Rock") return 6;

            // Draw
            else if (_player1Choice == "Rock" && _player2Choice == "Rock") return 7;
            else if (_player1Choice == "Paper" && _player2Choice == "Paper") return 8;
            else return 9;
        }

    }
}
