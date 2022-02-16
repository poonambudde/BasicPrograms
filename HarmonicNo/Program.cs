using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNo
{
    internal class Programs
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the value of N: ");
            //VARIABLES
            int N = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            float nthHarmonicValue = 0;

            while (i <= N)
            {
                Console.Write($"1/{i} + ");
                nthHarmonicValue += 1 / (float)i;
                i++;
            }
            Console.WriteLine($"\n{nthHarmonicValue}");
        }

    }

}

