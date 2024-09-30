using System;
class RPS {
  static void Main() {
    //
    int playerScore = 0;
    string playerChoice = "";
    int numDraws = 0;

    //cpu variables 
    int cpuScore = 0;
    string cpuChoice = "";
    int loopCount = 0;
    int loopsReqs = 0; //req / reqs is universal abbreviations for request
    Console.WriteLine("how many loops do you need? type and integer and press enter");
    loopsReqs = Convert.ToInt32(Console.ReadLine());
    while (loopCount < loopsReqs)
    {
      //print the scores
      Random rnd = new Random();
      int cpuRand = rnd.Next(0, 2);

      if (cpuRand == 0)
      {
        cpuChoice = "rock";
      }
      else if (cpuRand == 1)
      {
        cpuChoice = "paper";
      }
      else if (cpuRand == 2)
      {
        cpuChoice = "scissors";
      }
      
      int playerRand = rnd.Next(0, 2);

      if (playerRand == 0)
      {
        playerChoice = "rock";
      }
      else if (playerRand == 1)
      {
        playerChoice = "paper";
      }
      else if (playerRand == 2)
      {
        playerChoice = "scissors";
      }

      if (playerChoice == "rock" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++;
      }
      else if (playerChoice == "rock" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!");
        numDraws++;
      }
      else if (playerChoice == "paper" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!");
        numDraws++;
      }
      else if (playerChoice == "paper" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      else if (playerChoice == "paper" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "paper")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("You win!\n");
        playerScore++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "scissors")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("It's a draw!");
        numDraws++;
      }
      else if (playerChoice == "scissors" && cpuChoice == "rock")
      {
        Console.WriteLine($"You chose {playerChoice} and the CPU chose {cpuChoice}.\n");
        Console.WriteLine("The CPU wins.\n");
        cpuScore++;
      }
      loopCount++;
      }
      Console.WriteLine("cpu won; " + cpuScore);
      Console.WriteLine("player won; " + playerScore);
      Console.WriteLine("draws; " + numDraws);
      if (playerScore > cpuScore)
      {
       Console.WriteLine("Congratulations, you are the winner!\n");
      }
      else
      {
        Console.WriteLine("The CPU has defeated you.\n");
      }
      
  }
}