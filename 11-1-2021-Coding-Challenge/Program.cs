using System;

namespace _11_1_2021_Coding_Challenge
{
    class Program
    {
        // 1
        /*
         * Create a function double UniqueFract(), which should sum all irreducible regular fractions between 0 and 1, 
         * in the numerator and denominator of which there are only single-digit numbers.
         * 
         * Notes:
         * Of the fractions 1/2 2/4 3/6 4/8, only 1/2 is included in the sum.
         * Don't include any values >= 1.
         * Both the numerator and denominator are single digit.
         */
        static double UniqueFract()
        {
            // stores the sum
            double sum = 0;

            
            // stores the denominator
            int denominator = 2;
            while (denominator < 10)
            {
                // stores the numerator
                int numerator = 1;
                while (numerator < denominator)
                {
                    int divisor = GCD(numerator, denominator);
                    // if GCD is 1, then fraction non-reducible
                    if (divisor == 1)
                    {
                        sum += ((double)numerator / (double)denominator);
                    }

                    numerator++;
                }

                denominator++;
            }

            return sum;
        }

        /*
         * Returns the Greatest common divisor between two numbers.
         */
        static int GCD(int x, int y)
        {
            if (y == 0)
            {
                return x;
            }

            return GCD(y, x % y);
        }



        // 2
        /*
         * Consider the following operation on an arbitrary positive integer:
         * If n is even -> n / 2
         * If n is odd -> n * 3 + 1
         * Create a function to repeatedly evaluate these operations, until reaching 1. Return the number of steps it took.
         */
        static void collatz(int positiveInt)
        {
            // variable to stored number of steps
            int steps = 0;
            // stores original int value to print
            int printPositiveInt = positiveInt;

            while (positiveInt > 1)
            {
                // if given interger gives no remainder after dividing by 2, it is even.
                if (positiveInt % 2 == 0)
                {
                    positiveInt = positiveInt / 2;
                }
                else 
                {
                    positiveInt = positiveInt * 3 + 1;
                }
                steps++;
            }

            Console.WriteLine("It took '" + steps + "' steps to reach 1 from integer: " + printPositiveInt + "\n");
        }
          



        static void Main(string[] args)
        {
            Console.WriteLine("The sum of all irreducible regular fractions between 0 and 1 is: " + UniqueFract() + "\n");


            collatz(2);
            collatz(3);
            collatz(10);
        }
    }
}
