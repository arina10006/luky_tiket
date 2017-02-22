using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace luky_bilet
{
    class Program
    {
        static int SizeOfNumber(int number)
        {
            int size = 0;
            while (number > 0 )
            {
                number = number / 10;
                size++;
            }
            return size;
        }

        static int SummLeftOfNumber(int number, int halfOfSize)
        {
            int summLeftRight =0;
            int a = number / (int)Math.Pow(10, halfOfSize);
            while (a > 0)
            {
                summLeftRight = summLeftRight + a % 10;
                a = a / 10;
            }
            return summLeftRight;
        }

        static int SummRightOfNumber(int number, int halfOfSize, int size)
        {
            int summRight = 0;
            if (size % 2 == 0)
            {
                int a = number % (int)Math.Pow(10, halfOfSize);
                while (a > 0)
                {
                    summRight = summRight + a % 10;
                    a = a / 10;
                }

            }
            else
            {
                int a = number % (int)Math.Pow(10, halfOfSize +1) ;
                while (a > 0)
                {
                    summRight = summRight + a % 10;
                    a = a / 10;
                }

                
            }
            return summRight;
        }

        static bool ComparisonOfTheTwoHalves(int summLeft, int summRight)
        {
            bool compare = summLeft == summRight;

            return compare;
        }

        static void Main(string[] args)
        {
            int number =9874786;

            int size = SizeOfNumber(number);

            Console.WriteLine("size = {0}", size);

            Console.WriteLine("number = {0}", number);
            int halfOfSize = size / 2;
            Console.WriteLine("halfOfSize = {0}", halfOfSize);

            int summLeft = SummLeftOfNumber(number, halfOfSize);

            Console.WriteLine("summLeft = {0}", summLeft);

            int summRight = SummRightOfNumber(number, halfOfSize, size);

            Console.WriteLine("summRight = {0}", summRight);

            bool compare = ComparisonOfTheTwoHalves(summLeft, summRight);
            if (compare)
            {
                Console.WriteLine("Билетик счастливый");
            }
            else
            {
                Console.WriteLine("Билетик не счастливый");
            }
            
        }
    }
}
