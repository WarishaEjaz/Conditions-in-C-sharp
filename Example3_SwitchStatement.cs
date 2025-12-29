using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());

            switch(age)
            {
                case 15:
                    Console.WriteLine("Not eligible to vote");
                    break;
                case 16:
                    Console.WriteLine("Not eligible to vote");
                    break;
                case 17:
                    Console.WriteLine("Not eligible to vote");
                    break;
                case 18:
                    Console.WriteLine("Eligible to vote");
                    break;
                case 19:
                    Console.WriteLine("Eligible to vote");
                    break;
                default:
                    Console.WriteLine("INVALID AGE");
                    break;

            }
        }
    }
}
