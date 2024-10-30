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
Console.WriteLine("The elements of string array are:");
Console.WriteLine("breakfastFoods: " + String.Join(", ", breakfastFoods));
Console.WriteLine();

Console.WriteLine("The elements of int array are:");
Console.WriteLine("testScores: " + String.Join(", ", testScores));
Console.WriteLine();

Console.WriteLine("The elements of double array are:");
Console.WriteLine("gpa: " + String.Join(", ", gpa));
Console.WriteLine();

//print array elements on seperate lines
Console.WriteLine("The elements of double array are:");
Console.WriteLine("gpa: " + String.Join("\n ", gpa));
Console.WriteLine(); //print an empty line to the screen

//how long is my array? determining array length
Console.WriteLine("the length of the breakfastFoods array is; " + breakfastFoods.Length);
//.length is known as a property of the array

//accessing elements in the array with the index
Console.WriteLine("the first element in breakfastFoods is; " + breakfastFoods[0]);

//print the 2nd element of the gpa array
Console.WriteLine("the second element in gpa is; " + gpa[1]);

//print the 3rd element of the test scores array
Console.WriteLine("the third element in testscores is; " + testScores[2]);
  } //end
}