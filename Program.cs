using System;
using System.Collections.Generic;
using System.Linq;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {
            // var hearts = new List<string>() { "❤️A", "❤️1", "❤️2", "❤️3", "❤️4", "❤️5", "❤️6", "❤️7", "❤️8", "❤️9", "❤️10", "❤️J", "❤️Q", "❤️K" };
            var deck = new List<String>() { "♥︎A", "❤️1", "❤️2", "❤️3", "❤️4", "❤️5", "❤️6", "❤️7", "❤️8", "❤️9", "❤️10", "❤️J", "❤️Q", "❤️K", "♠︎A", "♠︎1", "♠︎2", "♠︎3", "♠︎4", "♠︎5", "♠︎6", "♠︎7", "♠︎8", "♠︎9", "♠︎10", "♠︎J", "♠︎Q", "♠︎K", "♣︎A", "♣︎1", "♣︎2", "♣︎3", "♣︎4", "♣︎5", "♣︎6", "♣︎7", "♣︎8", "♣︎9", "♣︎10", "♣︎J", "♣︎Q", "♣︎K", "♦︎A", "♦︎1", "♦︎2", "♦︎3", "♦︎4", "♦︎5", "♦︎6", "♦︎7", "♦︎8", "♦︎9", "♦︎10", "♦︎J", "♦︎Q", "♦︎K" };
            var n = deck.Count();
            var randomNumberGenerator = new Random();
            for (int index = 0; index < n; index++)
            {
                var randomNumber = randomNumberGenerator.Next(0, n);
                var placeholder = deck[randomNumber];
                deck[randomNumber] = deck[index];
                deck[index] = placeholder;
            }
            Console.WriteLine(deck[1]);
            Console.WriteLine(deck[0]);





        }

    }
}
