﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CardGames
{
    public class Dealer 
    {
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First());//add the first card in the deck to the hand
            string card = string.Format(Deck.Cards.First().ToString() + "\n");
            Console.WriteLine(card);//writes the hand that was dealt in this iteration of the loop
            using (StreamWriter file = new StreamWriter(@"C:\Users\Josep\Desktop\log.txt", true))
            {
                file.WriteLine(card);
            }
            Deck.Cards.RemoveAt(0);//removes card from the Deck.Card list
        }
    }
}
