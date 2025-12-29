using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example1_ifstatement
{
   class Program
    {
        static void Main(string[] args)
        {
            const double rate_per_unit = 12.5; 

            // define the fixed rate per unit as a constant ( it can't change )
           
            Console.WriteLine("enter unit used :");
            int unit_used = int.Parse(Console.ReadLine());

            // calculate the total bill by multiplying units used by the rate per unit
            double bill = unit_used * rate_per_unit;

            // if unit used is over 300 add a surcharge of 500
            if (unit_used > 300)
            {
                bill += 500;
            } 
            Console.WriteLine("TOTAL BILL :" + bill);


        }
    }
}
