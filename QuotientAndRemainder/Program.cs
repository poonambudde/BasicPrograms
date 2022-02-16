using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotientAndRemainder 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dividend, divisor, quotient, remainder;
            Console.WriteLine("Enter Dividend and divisor");
            dividend = Convert.ToInt32(Console.ReadLine());
            divisor = Convert.ToInt32(Console.ReadLine());
            quotient = dividend / divisor;
            remainder = dividend % divisor;
            Console.WriteLine("Quotient is " + quotient);
            Console.WriteLine("Remainder is " + remainder);
        }
    }
}