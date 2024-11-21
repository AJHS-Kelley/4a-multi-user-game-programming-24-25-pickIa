using System;
using System.Linq;
using System.Collections;

class MoreArrays {
  static void Main() { //start

    /*string[] colors = {"garnet", "gold", "purple", "teal", "fuschia"};
    //  looping through arrays the old way
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
    //  your loop should iterate through the entire array
    //  print the value on the screen 
    //  if the number is even, print on screen
    //  if odd, print that to the screen
    
    
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
    } */


  //  multidimensional arrays
  // this class will only use 2 dimensional arrays
    int[,] nums = {{2, 4, 6}, {-1, 0, 1}};

  // accessing items in 2d arrays
  //Console.WriteLine(nums[0, 1]);
  //Console.WriteLine(nums[1, 1]);

  //  changing elements in 2d arrays
  nums[1, 2] = 9001;
  //  change any element from the first array
  nums[0, 0] = 22;

//  looping through 2d arrays
//foreach (int i in nums)
//{
//    Console.WriteLine(i);
//}

//  looping through 2d arrays
for (int i = 0; i < nums.GetLength(0); i++)
{
  for (int j = 0; j < nums.GetLength(1); j++)
  {
    Console.WriteLine(nums[i, j]);
  }
}


  } //end
}