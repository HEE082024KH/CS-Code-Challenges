public class Challenge_one
{
    public void PrintNumbers()
    {
        // Todo: Print out the numbers 1 - 10
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }
    }

    public void PrintStrings(string[] arr)
    {
        /* Todo: Print out each string that is passed to the array as an argument*/
        string[] challengeArray = { "one", "two", "three" };
        foreach (string a in challengeArray)
        {
            Console.WriteLine(a);
        }
    }

    public void CheckIfNumberIsPositiveOrNegative(int number)
    {
        /*
        Todo: Check if a number is positive, negative or zero.
        */
        int i = Convert.ToInt32(Console.ReadLine());
        if (i > 0)
        {
            Console.WriteLine("Number is positive");
        }
        else if (i < 0)
        {
            Console.WriteLine("Negative is negative");
        }
        else
        {
            Console.WriteLine("Number is zero");
        }

    }


}