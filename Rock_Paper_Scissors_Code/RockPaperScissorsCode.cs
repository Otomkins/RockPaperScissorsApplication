using System;
using System.Collections.Generic;
using System.Text;

namespace Rock_Paper_Scissors_Code
{
    public class RockPaperScissorsCode
    {
        readonly RockPaperScissorsService _rpss = new RockPaperScissorsService();

        public void SetPlayerChoice(int playerChoice) => _rpss.SetPlayerChoice(playerChoice);

        public int RetrievePlayer1Score() => _rpss.RetrievePlayer1Score();

        public int RetrievePlayer2Score() => _rpss.RetrievePlayer2Score();

        public string RetrievePlayer1Choice() => _rpss.RetrievePlayer1Choice();

        public string RetrievePlayer2Choice() => _rpss.RetrievePlayer2Choice();

        public string RetrieveOutcome() =>  _rpss.DetermineWinner();

        public void RestartGame() => _rpss.RestartGame();




    }
}
