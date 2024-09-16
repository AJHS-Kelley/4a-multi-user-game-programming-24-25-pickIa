using System;
class RockPaperScissors {
  static void Main() {
    int playerScore = 0;
    int games = 1;
    int playerGuess;

    Console.WriteLine("Hello, enter your name here ");
    string playerName =  Console.ReadLine();
    Console.WriteLine("Hello " + playerName + ", this game is rock paper scissors.");
    Console.WriteLine("There are three rules.\n 1.Rock beats scissors, Paper beats rock, and Scissors beats paper.\n 2.The winner scores a point, if both players pick the same then no points are rewarded.\n 3.The first player to 5 wins.");

    Random rnd = new Random(); 
    int cpuGuess = rnd.Next(10); 
    while (games < 5)
    {
      Console.WriteLine("Pick a choice; 1.Rock, 2.Paper, 3.Scissors");
      playerGuess = Convert.ToInt32(Console.ReadLine());
      if (playerGuess == 1)
      {
        Console.WriteLine("Your guess is Rock");
        break;
      }
      else if (playerGuess == 2)
      {
        Console.WriteLine("Your guess is Paper");
        break;
      }
      else 
      {
        Console.WriteLine("Your guess is Scissors");
        break; 
      }
    }
  }
}