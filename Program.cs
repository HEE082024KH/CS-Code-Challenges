namespace CS_Code_Challenges;

class Program
{
    static void Main(string[] args)
    {
        Challenge_one one = new Challenge_one();
        Challenge_two two = new Challenge_two();
        Challenge_three three = new Challenge_three();


        // validate some methods
        void ValidateRecursiveFactorial()
        {
            // int n = 5;
            // int expected = 120; // 5! = 120
            // int result = three.RecursiveFactorial(n);

            // if (result == expected)
            // {
            //     Console.WriteLine($"Test passed: RecursiveFactorial({n}) = {expected}");
            // }
            // else
            // {
            //     Console.WriteLine($"Test failed: RecursiveFactorial({n}) = {result}, expected: {expected}");
            // }

            // Challenge one
            Challenge_one one = new();
            one.PrintNumbers();
            Console.WriteLine();

            string[] challengeArray = ["one", "two", "three"];
            one.PrintStrings(challengeArray);
            Console.WriteLine();

            int i = 0;
            one.CheckIfNumberIsPositiveOrNegative(i);
            Console.WriteLine();

            // Challenge two
            Challenge_two two = new();
            two.GuessNumber();
            Console.WriteLine();

            int n = 0;
            two.Fibonacci(n);
            Console.WriteLine();
        }

        ValidateRecursiveFactorial();
    }
}
