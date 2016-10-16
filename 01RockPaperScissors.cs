using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter hand 1:");
            string hand1 = Console.ReadLine().ToLower();
            Console.WriteLine("Enter hand 2");
            string hand2 = Console.ReadLine().ToLower();
            Console.WriteLine(CompareHands(hand1, hand2));
        }

        public static string CompareHands ( string hand1, string hand2)
        {
            //Your code here
            if (hand1 == hand2)
            {
                Console.WriteLine("It's a tie!");
            }

            if (hand1 == "rock")
            {
                if (hand2 == "scissors")
                {
                    Console.WriteLine("Hand one wins!");
                }
                Console.WriteLine("Hand two wins!");
            }

            if (hand1 == "paper")
            {
                if (hand2 == "rock")
                {
                    Console.WriteLine("Hand one wins!");
                }
                Console.WriteLine("Hand two wins!");
            }

            if (hand1 == "scissors")
            {
                if (hand2 == "paper")
                {
                    Console.WriteLine("Han one wins!");
                }
                Console.WriteLine("Hand two wins!");
            }
        }
    }
}
