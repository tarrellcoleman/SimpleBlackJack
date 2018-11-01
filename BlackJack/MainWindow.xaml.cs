using System;
using System.Collections.Generic;
using System.IO;
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


namespace BlackJack
{
    public partial class MainWindow : Window
    {
        public static string fileName;
        public static bool startOfGame = true;
        public static bool restart = false;

        public MainWindow()
        {
            InitializeComponent();
            startGame();
        }
        public void startGame()
        {
            Game.dealShuffle();
            setPlayerImages();
            setComputerImages();
            Game.playing = false;
            Game.gamePlay();
            score.Content = Game.scoreLabel;
            btnClicked();
        }
        public void btnClicked()
        {
            btnHit.Click += eventHandler;
            btnStand.Click += eventHandler;
        }

        public void eventHandler(object sender, EventArgs e)
        {
            string buttonText = ((Button)sender).Name;
            switch (buttonText)
            {
                case "btnHit":
                    Game.hitButton = true;
                    Game.playing = true;
                    Game.gamePlay();
                    setPlayerImages();
                    score.Content = Game.scoreLabel;
                    gameLabel.Content = Game.gameLabel;
                    break;
                case "btnStand":
                    Game.hitButton = false;
                    Game.standButton = true;
                    Game.playing = true;
                    Game.gamePlay();
                    setComputerImages();
                    score.Content = Game.scoreLabel;
                    comScore.Content = Game.compSum;
                    gameLabel.Content = Game.gameLabel;
                    break;
            }
            if (Game.playerTurn == false)
            {
                setComputerImages();
                comScore.Content = Game.compSum;
            }
        }


        public void setPlayerImages()
        {
            string path;
            int counter = 0;

            foreach (var card in Game.playerHand)
            {
                Image img = new Image();
                BitmapImage cards = new BitmapImage();

                cards.BeginInit();
                path = Environment.CurrentDirectory + $@"\assets\{card.fileName}.png";
                counter++;
                cards.UriSource = new Uri(path, UriKind.Absolute);
                cards.EndInit();
                object obj = FindName("card_" + counter.ToString());
                img.Source = cards;
                switch (counter)
                {
                    case 1:
                        card_1.Children.Add(img);
                        break;
                    case 2:
                        card_2.Children.Add(img);
                        break;
                    case 3:
                        card_3.Children.Add(img);
                        break;
                    case 4:
                        card_4.Children.Add(img);
                        break;
                    case 5:
                        card_5.Children.Add(img);
                        break;
                    case 6:
                        card_6.Children.Add(img);
                        break;
                    case 7:
                        card_7.Children.Add(img);
                        break;
                    default:
                        break;
                }
            }
        }

        public void setComputerImages()
        {
            string path;
            int counter = 0;

            foreach (var card in Game.computerHand)
            {

                Image img = new Image();
                BitmapImage cards = new BitmapImage();
                cards.BeginInit();
                path = Environment.CurrentDirectory + $@"\assets\{card.fileName}.png";

                counter++;
                if (counter == 2 && startOfGame == true)
                {
                    path = Environment.CurrentDirectory + $@"\assets\backCard.png";
                }
                cards.UriSource = new Uri(path, UriKind.Absolute);
                cards.EndInit();
                img.Source = cards;

                switch (counter)
                {
                    case 1:
                        compCard_1.Children.Add(img);
                        break;
                    case 2:
                        if (startOfGame == true)
                        {
                            backCard_2.Children.Add(img);
                            startOfGame = false;
                        }
                        else
                        {
                            compCard_2.Children.Add(img);
                        }
                        break;
                    case 3:
                        compCard_3.Children.Add(img);
                        break;
                    case 4:
                        compCard_4.Children.Add(img);
                        break;
                    case 5:
                        compCard_5.Children.Add(img);
                        break;
                    case 6:
                        compCard_6.Children.Add(img);
                        break;
                    case 7:
                        compCard_7.Children.Add(img);
                        break;
                    default:
                        break;
                }
            }
        }
        private void Window_Closed(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnQuit_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
