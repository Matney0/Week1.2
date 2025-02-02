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
           
            //Finding the loan amount
            Console.WriteLine("What is the principle amount of the loan in dollars?");
            //Turning it into an integer
            var principle = Convert.ToInt32(Console.ReadLine());
            //Asks user for intrest rate 
            Console.WriteLine("What is the current intrest rate?");
            //Converted rate into a double int since its not a whole number 
            double rate = Convert.ToDouble(Console.ReadLine());
            Console.ReadLine();
            //Asks users for the time of the loan
            Console.WriteLine("What is the period of the loan?");
            //Turning it into an integer 
            var time = Convert.ToInt32(Console.ReadLine());
            //Calculating the intrest by multiplying principle, rate, and loan time
            //Declared intrest 
            int intrest = principle *=(int)(rate *= time;
            Console.Read();
            //Reads and prints out the users current intrest rate 
            Console.WriteLine("Total intrest amount is" + principle);
            Console.ReadLine();
        }
    }
}
