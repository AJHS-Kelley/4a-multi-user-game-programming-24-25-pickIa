using System;
class guessNumber {
  static void Main() {
    int numGuess = 0;
    int maxGuess = 5;
    int guess;
    // generate the secret number here.
    Random rnd = new Random(); //create an object named 'rnd' that is a copy of the Random() class
    int secretNumber = rnd.Next(10); //generate from 0 to ?
    //int secretNumber = rnd.Next(25, 100) //generate from 25 to 999
    while (numGuess < maxGuess)
    {
      Console.WriteLine("Please guess the number between 0 and 10")
      guess = Convert.ToInt32(Console.ReadLine());
      Console.WriteLine(guess);
      numGuess++;
      if (guess < secretNumber)
      {
        Console.WriteLine("Your guess is too low.");
      }
      else if (guess > secretNumber)
      {
        Console.WriteLine("Your guess is too high.");
      }
      else 
      {
        Console.WriteLine("Your guess is correct!")
      }
    }
    //while loop
      //allow user to guess the number 
      // compare the guess to the secre number
      //if match print win, if > or <, give a hint
      //+1 to numguess
      //check if numguess > maxguesses
      //if ture, print a "lose game" message, if false guess again
  }
}