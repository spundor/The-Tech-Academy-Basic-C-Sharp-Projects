using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
   public class Deck
    {
        public Deck()//constructor 
        {
            Cards = new List<Card>();//instantiate property:Cards as an empty list of cards
                //then creates 2 more lists (Suits/Faces) & gives values
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two","Three","Four","Five","Six","Seven","Eight","Nine","Ten",
                "Jack","Queen","King","Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card();
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
        }
        public List<Card> Cards { get; set; }
    }
}
