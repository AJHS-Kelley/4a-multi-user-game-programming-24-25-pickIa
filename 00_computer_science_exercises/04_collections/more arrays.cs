using System;
using System.Linq;
using System.Collections;

class MoreArrays {
  static void Main() { //start

    string[] colors = {"garnet", "gold", "purple", "teal", "fuschia"};
    //looping through arrays the old way
    for (int i = 0; i < colors.Length; i++)
    {
      Console.WriteLine(colors[i]);
    }

    // looping through arrays 
    foreach (string i in colors)
    {
      Console.WriteLine(i);
    }

    int[] numbers = {-10, 25, -245, 45, 9999, 1, 0, 68, 538, -99999};
    /* your loop should iterate through the entire array
    print the value on the screen 
    if the number is even, print on screen
    if odd, print that to the screen
    */
    
    foreach (int i in numbers)
    {
      if (i % 2 == 0)
      {
        Console.WriteLine(i + " even");
      }
      else
      {
        Console.WriteLine(i + " odd");
      }
    }


  } //end
}