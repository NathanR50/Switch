using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many points did you earn?");
            int pointsEarned = int.Parse(Console.ReadLine());

            switch (pointsEarned)
            {
                case 0:
                    Console.WriteLine("You Lose");
                    break;
                case 1:
                    Console.WriteLine("needs practice");
                    break;

                    case 2:
                    Console.WriteLine("On target");
                    break;

                case 3:
                    Console.WriteLine("Superstar");
                    break;

                case 4:
                    Console.WriteLine("Over achiever");
                    break;

                case 5:
                    Console.WriteLine("Cheated");
                    break;

                default:
                
                    Console.WriteLine("invalid score entered");
                    break;
            }

        }
    }
}
