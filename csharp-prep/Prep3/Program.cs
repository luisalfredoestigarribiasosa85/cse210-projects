using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2:
        // Console.Write("What is the magic number? ");
        // int magicNumber = int.Parse(Console.ReadLine());


        //Random Numer to guess
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
            }
            else
            {
                Console.WriteLine("You Guessed it!");
            }
        }
    }
}