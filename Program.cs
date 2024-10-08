﻿namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Challenge_one one = new Challenge_one();
        Challenge_two two = new Challenge_two();
        Challenge_three three = new Challenge_three();

        // Challenge one
        one.PrintNumbers();
        Console.WriteLine();

        string[] challengeArray = [];
        one.PrintStrings(challengeArray);
        Console.WriteLine();

        double i = 0;
        Console.WriteLine("Positive, negative or zero");
        one.CheckIfNumberIsPositiveOrNegative(i);
        Console.WriteLine();

        // Challenge two
        two.GuessNumber();
        Console.WriteLine();

        two.Fibonacci(5);
        Console.WriteLine();

        int number = 0;
        Console.WriteLine("Even or Odd");
        two.CheckIfNumberIsEvenOrOdd(number);
        Console.WriteLine();

        // Challenge tree
        Console.WriteLine("FizzBuzz");
        three.FizzBuzz();
        Console.WriteLine();

        Console.WriteLine(three.ReverseString("Tullball"));

        // validate some methods
        void ValidateRecursiveFactorial()
        {
            Console.WriteLine("Factorial");
            int n = 5;
            int expected = 120; // 5! = 120
            int result = three.RecursiveFactorial(n);

            if (result == expected)
            {
                Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            }
            else
            {
                Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            }
        }

        ValidateRecursiveFactorial();
    }
}
