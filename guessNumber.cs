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

            while (gameOver == false) //while loop is easier to use cause you gonna put one thing in parenthesis
            {
                guess = Convert.ToInt32(Console.ReadLine()); //we have to convert a string
                numberOfGuesses--; //we have to substract number of guesses 

                if (guess != randomNumber && numberOfGuesses == 0) //if guess is NOT equal to random number
                {
                    Console.WriteLine("wow, you had three guesses and you can't figure it out ? You loose!");
                    gameOver = true;
                }
                // if guess == randomNumber


                // if guess > randomNumber


                //if guess < randomNumber

            }
            Console.ReadLine();
        }
    }
}


