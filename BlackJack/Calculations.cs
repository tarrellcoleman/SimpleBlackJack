using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class Calculations
    {
        
        public int addScore(List<CardCharacteristics> hand)
        {
            int sum = 0;
            foreach (var card in hand)
            {
                sum += card.faceNumber;
            }
            return sum;
        }

        public void determineWinner (int computerSum, int playerSum)
        {

            if(computerSum > playerSum && !(computerSum >= 22))
            {
                Game.gameLabel = "ComputerWins!";
            }
            if(playerSum > computerSum && !(playerSum >= 22))
            {
                Game.gameLabel = "PlayerWins!";
            }
            if(computerSum > 21)
            {
                Game.gameLabel = "PlayerWins!";
            }
            if (playerSum == 21 && computerSum == 21)
            {
                Game.gameLabel = "Tie!";
            }
            if(playerSum == computerSum)
            {
                Game.gameLabel = "Tie!";
            }
        }
        public void containsAce(List<CardCharacteristics> hand, int score)
        {
            if ((score + 10) <= 21)
            {
                foreach (var card in hand)
                {
                    if (card.faceNumber == 1)
                    {
                        card.faceNumber = 11;
                    }
                }
            }
            else
            {
                foreach (var card in hand)
                {
                    if (card.faceNumber == 1 || card.faceNumber == 11)
                    {
                        card.faceNumber = 1;
                    }
                }
            }
        }
        public static bool gotBlackJack(int score, int compScore)
        {
            bool blackjack = false;
            Calculations calc = new Calculations();
            if(score == 21)
            {
                blackjack = true;
                while (compScore < 17)
                {
                    DeckFunctions.hit(Game.deck, Game.computerHand);
                    if(Game.computerAce.Any())
                    {
                        calc.containsAce(Game.computerHand, Game.compSum);
                    }
                    Game.compSum = calc.addScore(Game.computerHand);
                }
            }
            return blackjack;
        }
    }
}
