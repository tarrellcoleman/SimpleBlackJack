using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public static class DeckFunctions
    {
        private static Random rdm = new Random();
        public static void shuffle (this List<CardCharacteristics> list)
        {
            
            int n = list.Count;

            while (n > 1)
            {
                n--;
                int k = rdm.Next(n + 1);
                CardCharacteristics value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        public static void deal (List<CardCharacteristics> deck, out List<CardCharacteristics> computer, out List<CardCharacteristics> player)
        {
            computer = deck.Take(2).ToList();
            foreach (var card in computer)
            {
                card.flag = 1;
            }
            
            player = deck.Skip(2).Take(2).ToList();

            foreach (var card in player)
            {
                card.flag = 1;
            }

        }
       

        public static List<CardCharacteristics> hit (List<CardCharacteristics> deck, List<CardCharacteristics> hand)
        {
            
            List<CardCharacteristics> cards = (from item in deck
                                             where item.flag != 1
                                             select item).ToList();

            var drawncard = cards.Take(1).ToList();
            hand.AddRange(drawncard);
            
            foreach(var card in hand)
            {
                card.flag = 1;
            }
            return hand;
        }
    }
}
