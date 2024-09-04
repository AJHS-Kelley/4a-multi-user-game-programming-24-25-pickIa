using System;
class ExtraLives {
  static void Main() {
    int lives = 1;
    Console.WriteLine("What is your score? Type it and press enter.");
    int score = Convert.ToInt32(Console.ReadLine());
     if (score < 10000) {
        lives--;
     }
     else if (score > 10000) {
      lives += 1;
     }
     else if (score > 100000) {
      lives += 2;
     }
     Console.WriteLine(lives);
  }
}