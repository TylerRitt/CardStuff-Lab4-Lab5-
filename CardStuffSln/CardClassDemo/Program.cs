using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CardClassLibrary;
namespace CardClassDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCardConstructors();
            Console.ReadLine();
        }
        
            static void TestCardConstructors()
            {
                Card c1 = new Card(2,2);
                Card c2 = new Card(2, 2);
                c1.IsAce();
                c1.IsBlack();
                c1.IsClub();
                c1.IsDiamond();
                c1.IsFaceCard();
                c1.IsHeart();
                c1.IsRed();
                c1.IsSpade();
                c1.ToString();
                c1.HasMatchingValue(c2);
                

                Console.WriteLine("Testing card class" + c1);
                
            }
        
    }
}
