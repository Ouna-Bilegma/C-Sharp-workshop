using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 11);//returns 1 less
            int guess;
            int numberOfGuesses = 3;
            bool gameOver = false;
            Console.WriteLine("Hello coder! I am thinking of a number between 1 and 10! what is it ?");

            while (gameOver == false) 
            {
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses--;

                if (guess != randomNumber && numberOfGuesses == 0)
                {
                    Console.WriteLine("wow, you had three guesses and you can't figure it out ? You loose!");
                    gameOver = true;
                }
                else if( guess == randomNumber)
                {
                    Console.WriteLine("That's it , you WIN!!");
                    gameOver = true;
                }
                else if (guess > randomNumber)
                Console.WriteLine("My number is smaller than that");
                else if (guess< randomNumber)
                    Console.WriteLine("My number is greater than that");

            }
            Console.ReadLine();
        }
    }
}
