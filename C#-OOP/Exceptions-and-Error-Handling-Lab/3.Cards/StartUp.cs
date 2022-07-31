using System;
using System.Collections.Generic;

namespace Card
{
    public class Card
    {
        public string Face { get; set; }

        public char Suit { get; set; }

        public Card(string face, char suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"[{this.Face}{this.Suit}]";
        }
    }
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            string[] input = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < input.Length; i++)
            {
                try
                {
                    string face = input[i].Split()[0];
                    string suitRaw = input[i].Split()[1];
                    char suit = 'A';
                    if (suitRaw == "D")
                    {
                        suit = '\u2666';
                    }
                    else if (suitRaw == "C")
                    {
                        suit = '\u2663';
                    }
                    else if (suitRaw == "H")
                    {
                        suit = '\u2665';
                    }
                    else if (suitRaw == "S")
                    {
                        suit = '\u2660';
                    }
                    Card card = CreateCard(face, suit);
                    cards.Add(card);
                }
                catch (ArgumentException ae)
                {

                    Console.WriteLine(ae.Message);
                }
            }


            cards.ForEach(x => Console.Write(x + " "));
        }

        static Card CreateCard(string face, char suit)
        {
            List<string> allowedFaces = new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<char> allowedSuits = new List<char> { '\u2660', '\u2665', '\u2666', '\u2663' };
            if (!allowedFaces.Contains(face))
            {
                throw new ArgumentException("Invalid card!");
            }
            if (!allowedSuits.Contains(suit))
            {
                throw new ArgumentException("Invalid card!");
            }
            Card card = new Card(face, suit);
            return card;
        }
    }
}
