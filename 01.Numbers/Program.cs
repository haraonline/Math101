﻿namespace _01.Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Number Sets");
            Console.WriteLine("Whole Numbers  : { 0, 1, 2, 3 ... }");
            Console.WriteLine("Natural or Counting Numbers : { 1, 2, 3 ... }");
            Console.WriteLine("Integers or + and - Numbers : ... { -3, -2, -1, 0, 1, 2, 3 ... }");
            Console.WriteLine("Rational Numbers: Integers + Fractions: { -6, -7/2, 3/4, 12 ... }");
            Console.WriteLine("Irrational Numbers: (Only) Real Numbers that cannot be writen as a fraction: \n3.14159, 1.414, 0.3333 ... squareRoot of 2, Pi etc");
            Console.WriteLine();
            Console.WriteLine("Irrational: all Real Numbers but Rational");
            Console.WriteLine("Overching Real Numbers: Rational + Irrational: 3.14159, 1.414, 0.3333 ...");
            Console.WriteLine();
            Console.WriteLine("--------------------------------------------------------------------");

            //Identity Numbers
            Console.WriteLine("Identity Numbers");
            Console.WriteLine("The most common identity numbers in mathematics are \nthe additive identity and the multiplicative identity");
            Console.WriteLine("Additive Identity: 0");
            Console.WriteLine("Multiplicative Identity: 1");
            Console.WriteLine("4 + 0 = 4");
            Console.WriteLine("4 * 1 = 4");
            Console.WriteLine("--------------------------------------------------------------------");
            
            Console.WriteLine("Negative Numbers:");
            Console.WriteLine("Negative numbers are numbers that are less than zero. \nThey are also called negative integers or negative whole numbers.");
            Console.WriteLine("Negative numbers are used to represent the opposite of a positive number.");
            Console.WriteLine("When any number is multiplied by -1, the result is the opposite of the original number.");
            Console.WriteLine("For example, if you multiply 5 by -1, the result is -5.The minuses gets cancelled here");
            int positiveNumber = 5;
            int minusOne = -1;
            int negativeNumber = positiveNumber * minusOne;
            Console.WriteLine("5 * -1 = {0}", negativeNumber);
            Console.WriteLine();
            
            Console.WriteLine("This is also same for negative numbers. For example: -5 * -1 = 5");
            int negativeFive = -5;
            int negativeFiveTimesMinusOne = negativeFive * minusOne;
            Console.WriteLine("-5 * -1 = {0}", negativeFiveTimesMinusOne);

            Console.WriteLine("--------------------------------------------------------------------");
            int x = 3 + 2 + -5 - 3;
            Console.WriteLine("3 + 2 + -5 - 3 : results in " + x);
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine();

            Console.WriteLine("Even number of negative signs is equal to a positive sign");
            Console.WriteLine("Odd number of negative signs is equal to a negative sign");
            Console.WriteLine("Here is an example:");
            Console.WriteLine(- - -2);
            Console.WriteLine(- - - -2);
            Console.WriteLine("When cancelled in pairs, even number of signs get striked out, the last odd numbered sign remains");






        }
    }
}