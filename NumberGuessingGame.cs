﻿// See https://aka.ms/new-console-template for more information
bool isCorrectGuess = false;
Random random = new Random();
int randomNum = random.Next(1, 11);

Console.WriteLine("Welcome to Number Guessing Game");
Console.WriteLine("A number between 1 and 10 will be generated. ");
Console.WriteLine("If you guess the correct number, you win!");

while (!isCorrectGuess)
{
    Console.WriteLine("Please enter your guess.");
    int guess = Convert.ToInt32(Console.ReadLine());

    if(guess > randomNum)
    {
        Console.WriteLine("Your guess is too high.");

    }

    else if (guess < randomNum)
    {
        Console.WriteLine("Your guess is too low.");
    }

    else
    {
        Console.WriteLine("Correct!");
        isCorrectGuess = true;
    }
}
Console.WriteLine("Congratulations, you have won the game!");
Console.ReadKey();
