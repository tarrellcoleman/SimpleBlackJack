using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BlackJack
{
    public class Game
    {
        public static List<CardCharacteristics> deck;
        public static List<CardCharacteristics> computerHand;
        public static List<CardCharacteristics> playerHand;
        public static List<CardCharacteristics> computerAce;

        public static string gameLabel;
        public static int scoreLabel;
        public static int comScoreLabel;

        public static int playerSum;
        public static int compSum;

        public static bool playing = true;
        public static bool hitButton = false;
        public static bool standButton = false;
        public static bool playerTurn = true;

        public static void dealShuffle()
        {
            CardDeck deckOfCards = new CardDeck();
            deck = deckOfCards.DeckList();
            deck.shuffle();

            DeckFunctions.deal(deck, out computerHand, out playerHand);
        }
        public static void gamePlay()
        {
            Calculations calculations = new Calculations();
            var popup = new Popup();
            var blackJack = Calculations.gotBlackJack(playerSum, compSum);
            popup.Visibility = System.Windows.Visibility.Hidden;
            playerSum = calculations.addScore(playerHand);
            compSum = calculations.addScore(computerHand);
            var playerAce = playerHand.Where(p => p.faceNumber == 1).ToList();
            computerAce = computerHand.Where(p => p.faceNumber == 1).ToList();
            if (playerAce.Any())
            {
                calculations.containsAce(playerHand, playerSum);
                playerSum = calculations.addScore(playerHand);
            }
            if (computerAce.Any())
            {
                calculations.containsAce(computerHand, compSum);
                compSum = calculations.addScore(computerHand);
            }
            scoreLabel = playerSum;
            blackJack = Calculations.gotBlackJack(playerSum, compSum);
            if (blackJack == true)
            {
                calculations.determineWinner(compSum, playerSum);
                popup.Visibility = System.Windows.Visibility.Visible;
                scoreLabel = playerSum;
                comScoreLabel = compSum;
                playerTurn = false;
                playing = false;
            }
            while (playing)
            {
                if (hitButton && !(playerSum > 21))
                {
                    DeckFunctions.hit(deck, playerHand);
                    playerSum = calculations.addScore(playerHand);
                    playerAce = playerHand.Where(p => p.faceNumber == 1).ToList();
                    if (playerAce.Any())
                    {
                        calculations.containsAce(playerHand, playerSum);
                        playerSum = calculations.addScore(playerHand);
                    }
                    if (playerSum > 21)
                    {
                        if (playerAce.Any())
                        {
                            calculations.containsAce(playerHand, playerSum);
                            playerSum = calculations.addScore(playerHand);
                        }
                        else
                        {
                            gameLabel = "Player Bust";
                            popup.Visibility = System.Windows.Visibility.Visible;
                            playerTurn = false;
                            comScoreLabel = compSum;
                            playing = false;
                        }
                    }
                    blackJack = Calculations.gotBlackJack(playerSum, compSum);
                    if (blackJack == true)
                    {
                        calculations.determineWinner(compSum, playerSum);
                        popup.Visibility = System.Windows.Visibility.Visible;
                        scoreLabel = playerSum;
                        comScoreLabel = compSum;
                        playerTurn = false;
                        playing = false;
                    }
                    playerSum = calculations.addScore(playerHand);
                    scoreLabel = playerSum;
                    playing = false;
                }
                else if (standButton)
                {
                    while(compSum < 17)
                    {
                        DeckFunctions.hit(deck, computerHand);
                        if (computerAce.Any())
                        {
                            calculations.containsAce(computerHand, compSum);
                        }
                        compSum = calculations.addScore(computerHand);
                    }
                    calculations.determineWinner(compSum, playerSum);
                    scoreLabel = playerSum;
                    comScoreLabel = compSum;
                    popup.Visibility = System.Windows.Visibility.Visible;
                    playing = false;
                }
                blackJack = Calculations.gotBlackJack(playerSum, compSum);
                if (blackJack == true)
                {
                    calculations.determineWinner(compSum, playerSum);
                    popup.Visibility = System.Windows.Visibility.Visible;
                    scoreLabel = playerSum;
                    comScoreLabel = compSum;
                    playerTurn = false;
                    playing = false;
                }
            }
        }
        public static void gameReset()
        {
            Application.Current.Shutdown();
            System.Diagnostics.Process.Start(Application.ResourceAssembly.Location);
        }
    }
}
