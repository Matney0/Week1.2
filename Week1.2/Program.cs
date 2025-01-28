using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaring intrest
            int intrest = 0;
            //Finding the loan amount
            Console.WriteLine("What is the principle amount of the loan in dollars?");
            //Turning it into an integer
            var principle = Convert.ToInt32(Console.ReadLine());
            //Asks user for intrest rate 
            Console.WriteLine("What is the current intrest rate?");
            //Turning it into an integer
            var rate = Convert.ToInt32(Console.ReadLine());
            //Asks users for the time of the loan
            Console.WriteLine("What is the period of the loan?");
            //Turning it into an integer 
            var time = Convert.ToInt32(Console.ReadLine());
            //Calculating the intrest by multiplying principle, rate, and loan time
            intrest = principle * rate * time;
            //Reads and prints out the users current intrest rate 
            Console.WriteLine("Total intrest amount is" + intrest);
            Console.ReadLine();
        }
    }
}
