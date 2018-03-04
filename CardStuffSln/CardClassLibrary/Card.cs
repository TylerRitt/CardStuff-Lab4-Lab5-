using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardClassLibrary
{
    public class Card
    {
        // value and suit use integers 1-4 for suit 1-13 for values for face cards 1 - club 2 - diamond - 3- heart 4- spade
        // careful setting up refrences
        // for setter use this.value = value
        private int value;
        private int suit;
    
        
        private string[] values = { "", "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "Ten", "Jack", "Queen", "King" };
        private string[] suits = { "", "Clubs", "Diamonds", "Hearts", "Spades" };
        Random generator = new Random();

        public Card()
        {
            value = 1;
            
            suit = 1;
        }

        public Card(int v, int s)
        {
            value = v;
            suit = s;
        }


        public bool IsAce()
        {

            if (this.value == 1)
            {   
                
                Console.WriteLine("This Is an Ace");
                Console.ReadLine();

                return true;
            }
            Console.ReadLine();
            return false;
        }

        public bool IsBlack()
        {
            if (this.suit == 1 || this.suit == 4)
            {
                Console.WriteLine("Card is Black");
                return true;
            }
            return false;
        }



        public bool IsClub()
        {
            if (this.suit == 1)
            {
                Console.WriteLine("Card is a Club");
                return true;
            }
            return true;
        }

        public bool IsDiamond()
        {

           if (this.suit == 2)
            {
                Console.WriteLine("Card is Diamond");

                return true;
            }
            return false;
        }

        public bool IsHeart()
        {
            if (this.suit == 3)
            {
                Console.WriteLine("Card is a Heart");
                return true;
            }
            return false;
        }

        public bool IsFaceCard()
        {
            if (this.value == 11 || this.value == 12 || this.value == 13)
            {
                Console.WriteLine("This is a Facecard");
                return true;
            }
            return false;
        }

        public bool IsRed()
        {
            if (this.suit == 2|| this.suit ==3)
            {
                Console.WriteLine("Card is Red");
                return true;
            }
            return false;
        }

        public bool IsSpade()
        {
            if (this.suit == 4)
            {

                Console.WriteLine("This is a Spade");
                
                return true;
            }
            
            return false;
        }

        public bool HasMatchingValue(Card other)
        {
            if (other.value == value)
                return true;
            else
                return false;

        }


        public string FileName
        {
            get
            {
                return "card" + values[value].Substring(0, 1) + 
                    suits[suit].Substring(0, 1) + ".jpg";
            }
        }



        public override string ToString()
        {
            return values[value] + " of " + suits[suit];
        }
        
    }
}
