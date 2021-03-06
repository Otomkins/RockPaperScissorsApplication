﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Rock_Paper_Scissors_Code;

namespace Rock_Paper_Scissors_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        RockPaperScissorsCode _rpsc = new RockPaperScissorsCode();

        BitmapImage _player1RockImage = new BitmapImage(new Uri("/Images/Player_1_Rock.png", UriKind.Relative));
        BitmapImage _player1PaperImage = new BitmapImage(new Uri("/Images/Player_1_Paper.png", UriKind.Relative));
        BitmapImage _player1ScissorsImage = new BitmapImage(new Uri("/Images/Player_1_Scissors.png", UriKind.Relative));

        int _roundCount = 1;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Player_1_Selection_Rock_Button_Click(object sender, RoutedEventArgs e)
        {
            Player_1_Choice_Image.Source = _player1RockImage;
            DisplayFinalOutcome(1);

        }

        private void Player_1_Selection_Paper_Button_Click(object sender, RoutedEventArgs e)
        {
            Player_1_Choice_Image.Source = _player1PaperImage;
            DisplayFinalOutcome(2);
        }

        private void Player_1_Selection_Scissors_Button_Click(object sender, RoutedEventArgs e)
        {
            Player_1_Choice_Image.Source = _player1ScissorsImage;
            DisplayFinalOutcome(3);
        }

        private void DisplayFinalOutcome(int player1Choice)
        {
            _rpsc.SetPlayerChoice(player1Choice);
            Round_Log_TextBox.Text = _rpsc.RetrieveOutcome();
            Player_1_Score_TextBox.Text = _rpsc.RetrievePlayer1Score().ToString();
            Player_2_Score_TextBox.Text = _rpsc.RetrievePlayer2Score().ToString();
            SetPlayer2Choice();

            Player_1_Selection_Rock_Button.IsEnabled = false;
            Player_1_Selection_Paper_Button.IsEnabled = false;
            Player_1_Selection_Scissors_Button.IsEnabled = false;
            Next_Round_Button.IsEnabled = true;
            Next_Round_Button.Opacity = 100;
        }

        private void SetPlayer2Choice()
        {
            switch (_rpsc.RetrievePlayer2Choice())
            {
                case "Rock":
                    Player_2_Choice_Image.Source = new BitmapImage(new Uri("/Images/Player_2_Rock.png", UriKind.Relative));
                    break;
                case "Paper":
                    Player_2_Choice_Image.Source = new BitmapImage(new Uri("/Images/Player_2_Paper.png", UriKind.Relative));
                    break;
                case "Scissors":
                    Player_2_Choice_Image.Source = new BitmapImage(new Uri("/Images/Player_2_Scissors.png", UriKind.Relative));
                    break;
            }
        }

        private void Next_Round_Button_Click(object sender, RoutedEventArgs e)
        {
            NewRoundUnrestrict();
            Round_Count_Label.Content = $"Round {++_roundCount}";
        }

        private void Game_Restart_Button_Click(object sender, RoutedEventArgs e)
        {
            NewRoundUnrestrict();
            _rpsc.RestartGame();

            Player_1_Score_TextBox.Text = _rpsc.RetrievePlayer1Score().ToString();
            Player_2_Score_TextBox.Text = _rpsc.RetrievePlayer2Score().ToString();
            _roundCount = 1;
            Round_Count_Label.Content = $"Round 1";
        }

        private void NewRoundUnrestrict()
        {
            Player_1_Selection_Rock_Button.IsEnabled = true;
            Player_1_Selection_Paper_Button.IsEnabled = true;
            Player_1_Selection_Scissors_Button.IsEnabled = true;

            Player_1_Choice_Image.Source = null;
            Player_2_Choice_Image.Source = null;
            Round_Log_TextBox.Text = "Make Your Selection....";
            Next_Round_Button.IsEnabled = false;
            Next_Round_Button.Opacity = 0;
        }
    }
}
