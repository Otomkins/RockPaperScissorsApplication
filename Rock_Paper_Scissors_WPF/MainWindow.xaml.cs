using System;
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

namespace Rock_Paper_Scissors_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        BitmapImage _player1RockImage = new BitmapImage(new Uri("/Images/Player_1_Rock.png", UriKind.Relative));
        BitmapImage _player1PaperImage = new BitmapImage(new Uri("/Images/Player_1_Paper.png", UriKind.Relative));
        BitmapImage _player1ScissorsImage = new BitmapImage(new Uri("/Images/Player_1_Scissors.png", UriKind.Relative));

        private void Player_1_Selection_Rock_Button_Click(object sender, RoutedEventArgs e)
        {
            Player_1_Choice_Image.Source = _player1RockImage;
        }

        private void Player_1_Selection_Paper_Button_Click(object sender, RoutedEventArgs e)
        {
            Player_1_Choice_Image.Source = _player1PaperImage;
        }

        private void Player_1_Selection_Scissors_Button_Click(object sender, RoutedEventArgs e)
        {
            Player_1_Choice_Image.Source = _player1ScissorsImage;
        }
    }
}
