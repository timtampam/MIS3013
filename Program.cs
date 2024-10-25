using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DicePlay
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables
            int userNum, actualNum, one = 0, two = 0, three = 0, four = 0, five = 0, six = 0;
            double win = 0, loss = 0, rate;
            string again;

            do
            {
                // generate rand number
                Random rand = new Random(); // random objec setup
                actualNum = rand.Next(1, 7); // 1-6

                // user input
                Console.WriteLine("Pick a number: (1, 2, 3, 4, 5, 6)");
                userNum = Convert.ToInt32(Console.ReadLine());

                if (userNum == actualNum)
                {
                    Console.WriteLine($"You win! It is: {actualNum}");
                    win++;
                }
                else
                {
                    Console.WriteLine($"Sorry you lose... the result is: {actualNum}");
                    loss++;
                }

                // count actual nums
                if (actualNum == 1)
                {
                    one++;
                }
                else if (actualNum == 2)
                {
                    two++;
                }
                else if (actualNum == 3)
                {
                    three++;
                }
                else if (actualNum == 4)
                {
                    four++;
                }
                else if (actualNum == 5)
                {
                    five++;
                }
                else if (actualNum == 6)
                {
                    six++;
                }

                Console.WriteLine("\nDo you want to play another game? (yes/no)");
                again = Console.ReadLine().ToLower();
            } while (again == "yes");

            // output
            rate = (win / (win + loss)) * 100;
            Console.WriteLine($"\nSuccess rate: {rate}%");
            Console.WriteLine("\nActual results: ");
            Console.WriteLine("one -- " + one);
            Console.WriteLine("two -- " + two);
            Console.WriteLine("three -- " + three);
            Console.WriteLine("four -- " + four);
            Console.WriteLine("five -- " + five);
            Console.WriteLine("six -- " + six);

            Console.ReadKey(); // end
        }
    }
}
