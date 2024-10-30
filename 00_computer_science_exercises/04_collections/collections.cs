// this is collections for samuel jenkins woah
using System;
using System.Linq;
using System.Collections;


class Collections {
  static void Main() { //start

/*
in c# a collection is known as an array
- each item in the array is an element
-- number of elements in the array cannot be changed
--- contents of each element can change
---- arrays are ordered meaning each item has a fixed position
----- position of the element is the index
------ first element index is 0
*/

// declaring and defining an array
string[] breakfastFoods = {"pancake", "bacon", "eggs", "grits", "cereal"};
int[] testScores = {5, 1, 2, 9, 6};
double[] gpa = {0.1, 0.99, 2.5, 3.55, 4.01};

//print array contents -- all elements on single line
Console.WriteLine("The elements of each array are:");
Console.WriteLine("breakfastFoods: " + String.Join(", ", breakfastFoods));
Console.WriteLine();
  } //end
}