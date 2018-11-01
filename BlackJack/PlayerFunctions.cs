using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    public class PlayerFunctions
    {
        //public bool hitOrStand(bool hit)
        //{
            
        //    if(hit == false)
        //    {
        //        Console.WriteLine("Player decided to stand");
        //    }
        //    else
        //    {
        //        Console.WriteLine("Player decided to hit");
        //    }
        //    return hit;
        //}


        public static bool aceInHand = false;
        public static bool softHand (List<CardCharacteristics> playerHand)
        {
            foreach(var card in playerHand)
            {
                if (card.faceNumber == 1)
                {
                    aceInHand = true;
                }
            }
            //if(playerHand >= 17)
            //{

            //}
            return aceInHand;
        }
    }
}
