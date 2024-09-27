public class Challenge_two
{
    public void GuessNumber()
    {
        int? secret = 69; // Assign the secret value
        int? guess = 0;
        while (guess != secret)
        {
            Console.WriteLine("Guess the secret number: ");
            guess = int.Parse(Console.ReadLine());
            // Todo: Implement the correct conditionals inside the while loop.
            switch (guess)
            {
                case 69:
                    Console.WriteLine("Correct answer");
                    break;
                default:
                    Console.WriteLine("Wrong!");
                    break;
            }
        }
    }

    public void Fibonacci(int n)
    {
        int a = 0, b = 1, c = n;
        Console.WriteLine($"{a} + {b} = {c}");
        // Todo: Write out the Fibonacci sequence, tips: use a for loop.
        for (int i = 2; i < n; i++)
        {
            c = a + b;
            Console.WriteLine(" {0}", c);
            a = b;
            b = c;
        }
    }

    public void CheckIfNumberIsEvenOrOdd(double a)
    {
        // Todo: Check if a number is even or odd
        // if the number is even, write out "even"
        // if the number is odd, write out "odd"
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is an even number.");
        }
        else
        {
            Console.WriteLine($"{number} is an odd number.");
        }
    }
}