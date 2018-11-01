using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class CardCharacteristics
    {
        public int faceNumber { get; set; }
        public string suit { get; set; }
        public int flag { get; set; }
        public string fileName { get; set; }

        
    }

    public class CardDeck
    {
        public List<CardCharacteristics> DeckList()
        {
            List<CardCharacteristics> deckOfCards = new List<CardCharacteristics>()
            {
                new CardCharacteristics{faceNumber = 1, suit = "Heart", flag = 0, fileName = "AceOfHearts"},
                new CardCharacteristics{faceNumber = 2, suit = "Heart", flag = 0, fileName = "TwoOfHearts"},
                new CardCharacteristics{faceNumber = 3, suit = "Heart", flag = 0, fileName = "ThreeOfHearts"},
                new CardCharacteristics{faceNumber = 4, suit = "Heart", flag = 0, fileName = "FourOfHearts"},
                new CardCharacteristics{faceNumber = 5, suit = "Heart", flag = 0, fileName = "FiveOfHearts"},
                new CardCharacteristics{faceNumber = 6, suit = "Heart", flag = 0, fileName = "SixOfHearts"},
                new CardCharacteristics{faceNumber = 7, suit = "Heart", flag = 0, fileName = "SevenOfHearts"},
                new CardCharacteristics{faceNumber = 8, suit = "Heart", flag = 0, fileName = "EightOfHearts"},
                new CardCharacteristics{faceNumber = 9, suit = "Heart", flag = 0, fileName = "NineOfHearts"},
                new CardCharacteristics{faceNumber = 10, suit = "Heart", flag = 0, fileName = "TenOfHearts"},
                new CardCharacteristics{faceNumber = 10, suit = "Heart", flag = 0, fileName = "KingOfHearts"},
                new CardCharacteristics{faceNumber = 10, suit = "Heart", flag = 0, fileName = "QueenOfHearts"},

                new CardCharacteristics{faceNumber = 1, suit = "Diamond", flag = 0, fileName = "AceOfDiamonds"},
                new CardCharacteristics{faceNumber = 2, suit = "Diamond", flag = 0, fileName = "TwoOfDiamonds"},
                new CardCharacteristics{faceNumber = 3, suit = "Diamond", flag = 0, fileName = "ThreeOfDiamonds"},
                new CardCharacteristics{faceNumber = 4, suit = "Diamond", flag = 0, fileName = "FourOfDiamonds"},
                new CardCharacteristics{faceNumber = 5, suit = "Diamond", flag = 0, fileName = "FiveOfDiamonds"},
                new CardCharacteristics{faceNumber = 6, suit = "Diamond", flag = 0, fileName = "SixOfDiamonds"},
                new CardCharacteristics{faceNumber = 7, suit = "Diamond", flag = 0, fileName = "SevenOfDiamonds"},
                new CardCharacteristics{faceNumber = 8, suit = "Diamond", flag = 0, fileName = "EightOfDiamonds"},
                new CardCharacteristics{faceNumber = 9, suit = "Diamond", flag = 0, fileName = "NineOfDiamonds"},
                new CardCharacteristics{faceNumber = 10, suit = "Diamond", flag = 0, fileName = "TenOfDiamonds"},
                new CardCharacteristics{faceNumber = 10, suit = "Diamond", flag = 0, fileName = "KingOfDiamonds"},
                new CardCharacteristics{faceNumber = 10, suit = "Diamond", flag = 0, fileName = "QueenOfDiamonds"},

                new CardCharacteristics{faceNumber = 1, suit = "Spade", flag = 0, fileName = "AceOfSpades"},
                new CardCharacteristics{faceNumber = 2, suit = "Spade", flag = 0, fileName = "TwoOfSpades"},
                new CardCharacteristics{faceNumber = 3, suit = "Spade", flag = 0, fileName = "ThreeOfSpades"},
                new CardCharacteristics{faceNumber = 4, suit = "Spade", flag = 0, fileName = "FourOfSpades"},
                new CardCharacteristics{faceNumber = 5, suit = "Spade", flag = 0, fileName = "FiveOfSpades"},
                new CardCharacteristics{faceNumber = 6, suit = "Spade", flag = 0, fileName = "SixOfSpades"},
                new CardCharacteristics{faceNumber = 7, suit = "Spade", flag = 0, fileName = "SevenOfSpades"},
                new CardCharacteristics{faceNumber = 8, suit = "Spade", flag = 0, fileName = "EightOfSpades"},
                new CardCharacteristics{faceNumber = 9, suit = "Spade", flag = 0, fileName = "NineOfSpades"},
                new CardCharacteristics{faceNumber = 10, suit = "Spade", flag = 0, fileName = "TenOfSpades"},
                new CardCharacteristics{faceNumber = 10, suit = "Spade", flag = 0, fileName = "KingOfSpades"},
                new CardCharacteristics{faceNumber = 10, suit = "Spade", flag = 0, fileName = "QueenOfSpades"},

                new CardCharacteristics{faceNumber = 1, suit = "Club", flag = 0, fileName = "AceOfClubs"},
                new CardCharacteristics{faceNumber = 2, suit = "Club", flag = 0, fileName = "TwoOfClubs"},
                new CardCharacteristics{faceNumber = 3, suit = "Club", flag = 0, fileName = "ThreeOfClubs"},
                new CardCharacteristics{faceNumber = 4, suit = "Club", flag = 0, fileName = "FourOfClubs"},
                new CardCharacteristics{faceNumber = 5, suit = "Club", flag = 0, fileName = "FiveOfClubs"},
                new CardCharacteristics{faceNumber = 6, suit = "Club", flag = 0, fileName = "SixOfClubs"},
                new CardCharacteristics{faceNumber = 7, suit = "Club", flag = 0, fileName = "SevenOfClubs"},
                new CardCharacteristics{faceNumber = 8, suit = "Club", flag = 0, fileName = "EightOfClubs"},
                new CardCharacteristics{faceNumber = 9, suit = "Club", flag = 0, fileName = "NineOfClubs"},
                new CardCharacteristics{faceNumber = 10, suit = "Club", flag = 0, fileName = "TenOfClubs"},
                new CardCharacteristics{faceNumber = 10, suit = "Club", flag = 0, fileName = "KingOfClubs"},
                new CardCharacteristics{faceNumber = 10, suit = "Club", flag = 0, fileName = "QueenOfClubs"},
            };


            return deckOfCards;
        }

    }
}
