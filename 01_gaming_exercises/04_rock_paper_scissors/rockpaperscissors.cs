using System;
class RockPaperScissors {
  static void Main() {
    int playerScore = 0;
    int games = 0;
    int playerGuess;   
    int cpuScore = 0;  
    Console.WriteLine("Hello, enter your name here ");
    string playerName =  Console.ReadLine();
    Console.WriteLine("Hello " + playerName + ", this game is rock paper scissors.");
    Console.WriteLine("There are three rules.\n 1.Rock beats scissors, Paper beats rock, and Scissors beats paper.\n 2.The winner scores a point, if both players pick the same then no points are rewarded.\n 3.The first player to 5 wins.");
  //code for game starting and integers

    while (playerScore < 5 && cpuScore < 5)
    {
      Random rnd = new Random(); 
      int cpuGuess = rnd.Next(3);
      int cpuChoice = cpuGuess += 1;
      Console.WriteLine("Pick a choice; 1.Rock, 2.Paper, 3.Scissors");
      playerGuess = Convert.ToInt32(Console.ReadLine());
  //getting player choice

      if (playerGuess == 1)
      {
        Console.WriteLine("Your guess is Rock");
      }
      else if (playerGuess == 2)
      {
        Console.WriteLine("Your guess is Paper");
      }
      else if (playerGuess == 3)
      {
        Console.WriteLine("Your guess is Scissors");
      }
      else 
      {
        Console.WriteLine("That is not a choice!");
      }
  //choice reply

    if (playerGuess == 1 && cpuChoice == 2)
    {
      Console.WriteLine("Paper beats rock! You lose!");
      cpuScore++;
    }
    if (playerGuess == 1 && cpuChoice == 3)
    {
      Console.WriteLine("Rock beats scissors! You win!");
      playerScore++;
    }
    if (playerGuess == 2 && cpuChoice == 1)
    {
      Console.WriteLine("Paper beats rock! You win!");
      playerScore++;
    }
    if (playerGuess == 2 && cpuChoice == 3)
    {
      Console.WriteLine("Scissors beats paper! You lose!");
      cpuScore++;
    }
    if (playerGuess == 3 && cpuChoice == 1)
    {
      Console.WriteLine("Rock beats scissors! You lose!");
      cpuScore++;
    }
    if (playerGuess == 3 && cpuChoice == 2)
    {
      Console.WriteLine("Scissors beats paper! You win!");
      playerScore++;
    }
  //winning or losing and points

    if (playerGuess == 1 && cpuChoice == 1)
    {
      Console.WriteLine("Rock... doesnt beat rock. Its a tie!");
    }
    if (playerGuess == 2 && cpuChoice == 2)
    {
      Console.WriteLine("Are you trying to make origami? Its a tie!");
    }
    if (playerGuess == 3 && cpuChoice == 3)
    {
      Console.WriteLine("You chose the same! Its a tie!");
    }
    //ties
    }
    if (playerScore > cpuScore)
    {
        Console.WriteLine("\nYou won the game!");
    }
    if (playerScore == cpuScore)
    {
        Console.WriteLine("\nYou both tied!");
    }
    if (playerScore < cpuScore)
    {
        Console.WriteLine("\nYou lose the game!");
    }
  }
}