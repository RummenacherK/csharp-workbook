using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Play?(y/n)");
            string playGame = Console.ReadLine().ToLower();
            do
            {
                Console.WriteLine("Enter hand 1:");
                string hand1 = Console.ReadLine().ToLower();
                Console.WriteLine("Enter hand 2:");
                string hand2 = Console.ReadLine().ToLower();
                Console.WriteLine(CompareHands(hand1, hand2));

                Console.ReadLine();
            } while (playGame == "y");
        }

        public static string CompareHands(string hand1, string hand2)
        {
                if (hand1 == hand2)
                {
                    return "It's a tie!";
                }
                if (hand1 == "rock")
                {
                    if (hand2 == "scissors")
                    {
                        return "Hand one wins!";
                    }
                    return "Hand two wins!";
                }

                if (hand1 == "paper")
                {
                    if (hand2 == "rock")
                    {
                        return "Hand one wins!";
                    }
                    return "Hand two wins!";
                }

                if (hand1 == "scissors")
                {
                    if (hand2 == "paper")
                    {
                        return "Hand one wins!";
                    }
                    return "Hand two wins!";
                }
                return "Uh, that doesn't compute. Uh, wait, uh, you're under arrest!";
          
        }
    }
}

