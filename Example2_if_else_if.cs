using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sub1, sub2, sub3, sub4, sub5;
            int total;
            double percentage;

            Console.WriteLine("Enter marks of 5 subjects:");

            Console.Write("Subject 1: ");
            sub1 = int.Parse(Console.ReadLine());

            Console.Write("Subject 2: ");
            sub2 = int.Parse(Console.ReadLine());

            Console.Write("Subject 3: ");
            sub3 = int.Parse(Console.ReadLine());

            Console.Write("Subject 4: ");
            sub4 = int.Parse(Console.ReadLine());

            Console.Write("Subject 5: ");
            sub5 = int.Parse(Console.ReadLine());

            total = sub1 + sub2 + sub3 + sub4 + sub5;
            percentage = total / 5.0;

            Console.WriteLine("Total Marks = " + total);
            Console.WriteLine("Percentage = " + percentage);

            // Checking pass or fail
            if (sub1 < 33 || sub2 < 33 || sub3 < 33 || sub4 < 33 || sub5 < 33)
            {
                Console.WriteLine("Result: FAIL");
            }
            else
            {
                Console.WriteLine("Result: PASS");

                // Grade calculation using if else if
                if (percentage >= 90)
                {
                    Console.WriteLine("Grade: A+");
                }
                else if (percentage >= 80)
                {
                    Console.WriteLine("Grade: A");
                }
                else if (percentage >= 70)
                {
                    Console.WriteLine("Grade: B");
                }
                else if (percentage >= 60)
                {
                    Console.WriteLine("Grade: C");
                }
                else if (percentage >= 50)
                {
                    Console.WriteLine("Grade: D");
                }
                else
                {
                    Console.WriteLine("Grade: E");
                }
            }

            Console.ReadLine();
        }
    }

}
    }
}
