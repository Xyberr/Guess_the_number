using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game!");

            // Генерация случайного числа
            Random random = new Random();
            int number = random.Next(1, 101);

            int guess = 0;
            int attempts = 0;

            // Цикл угадывания числа
            while (guess != number)
            {
                Console.Write("Enter a number between 1 and 100: ");
                guess = int.Parse(Console.ReadLine());
                attempts++;

                if (guess < number)
                {
                    Console.WriteLine("Too low! Try again.");
                }
                else if (guess > number)
                {
                    Console.WriteLine("Too high! Try again.");
                }
                else
                {
                    Console.WriteLine($"Congratulations! You guessed the number in {attempts} attempts!");
                }
            }

            Console.ReadLine();
        }
    }
}