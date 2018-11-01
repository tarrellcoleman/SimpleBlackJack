using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class ComputerFunctions
    {
        public static bool hit;
        public bool computerHitOrStand (int total, List<CardCharacteristics> deck)
        {
            if (total >= 17)
            {
                Console.WriteLine("Computer must Stand!");
                //hit = false;
            }
            if(total <= 16)
            {
                Console.WriteLine("Computer must Hit!");
                
                DeckFunctions.hit(deck, Game.computerHand);
               
            }
            return hit;
        }

    }
}
