// this is collections for samuel jenkins woah
using System;
using System.Linq;
using System.Collections;


class Collections {
  static void Main() { //start

/*
// in c# a collection is known as an array
// - each item in the array is an element
// -- number of elements in the array cannot be changed
// --- contents of each element can change
// ---- arrays are ordered meaning each item has a fixed position
// ----- position of the element is the index
// ------ first element index is 0
// */

// // declaring and defining an array
// string[] breakfastFoods = {"pancake", "bacon", "eggs", "grits", "cereal"};
// int[] testScores = {5, 1, 2, 9, 6};
// double[] gpa = {0.1D, 0.99D, 2.5D, 3.55D, 4.01D};

// //print array contents -- all elements on single line
// Console.WriteLine("The elements of string array are:");
// Console.WriteLine("breakfastFoods: " + String.Join(", ", breakfastFoods));
// Console.WriteLine();
// /*
// Console.WriteLine("The elements of int array are:");
// Console.WriteLine("testScores: " + String.Join(", ", testScores));
// Console.WriteLine();

// Console.WriteLine("The elements of double array are:");
// Console.WriteLine("gpa: " + String.Join(", ", gpa));
// Console.WriteLine();

// //print array elements on seperate lines
// Console.WriteLine("The elements of double array are:");
// Console.WriteLine("gpa: " + String.Join("\n ", gpa));
// Console.WriteLine(); //print an empty line to the screen

// //how long is my array? determining array length
// Console.WriteLine("the length of the breakfastFoods array is; " + breakfastFoods.Length);
// //.length is known as a property of the array

// //accessing elements in the array with the index
// Console.WriteLine("the first element in breakfastFoods is; " + breakfastFoods[0]);

// //print the 2nd element of the gpa array
// Console.WriteLine("the second element in gpa is; " + gpa[1]);

// //print the 3rd element of the test scores array
// Console.WriteLine("the third element in testscores is; " + testScores[2]);

// // shortcut to access last item in an array
// Console.WriteLine("The last element of breakfastfoods is; " + breakfastFoods[breakfastFoods.Length - 1]);
// Console.WriteLine("the last element of gpa is; " + gpa[gpa.Length - 1]);
// */
// //changing elements in the array
// // breakfastFoods[2] = "green eggs and ham";
// // gpa[3] = 2.3D;
// // testScores[0] = 99;
// // Console.WriteLine("The elements of string array are:");
// // Console.WriteLine("breakfastFoods: " + String.Join(", ", breakfastFoods));
// // Console.WriteLine();

// //common errors with arrays
// //Console.WriteLine(breakfastFoods[99]); //index out of bounds
// //testScores[0] "99"; error message "cannot implicitly conver dataType to datatype" = wrong data type inputted

// //common array methods
// // sorting an array
// int[] intArr = {-2, 3, 4, -5, 22, 19, 102, 99, -55, 1};
// string[] zooAnimals = {"horse", "dog", "cat", "shoe", "tortilla", "turducken", "fart", "thewholenumberof23", "acomma", "portapotty"};

// Array.Sort(intArr);
// Array.Sort(zooAnimals);
// //  Console.WriteLine("The elements of string array are:");
// //  Console.WriteLine("zooAnimals: " + String.Join(", ", zooAnimals));
// //  Console.WriteLine();
// //   Console.WriteLine("The elements of string array are:");
// //  Console.WriteLine("intArr: " + String.Join(", ", intArr));
// //  Console.WriteLine();

// //finding the min, max and sum for numerical arrays
// Console.WriteLine("the minimum value for intArr is; " + intArr.Min());
// Console.WriteLine("the maximum value for intArr is; " + intArr.Max());
// Console.WriteLine("the sumimum value for intArr is; " + intArr.Sum());

//ArrayList --> basically an array you can add/remove elements from
//.add() puts it at the end of the list
// var exampleArrList = new ArrayList(); //create a new ArrayList
// exampleArrList.Add(5);
// exampleArrList.Add(false);
// exampleArrList.Add(1.25D);
// exampleArrList.Add("shrek 5");

// create ArrayList with values
// var exampleArrList2 = new ArrayList()
//   {
//     -10, "last name", "purple", false, 25.25D, 195000, 0.0
//   };

// Console.WriteLine(exampleArrList[2]);
// Console.WriteLine(exampleArrList2[5]);  

//inserting to a specific value position in the array list
//use .insert(index, value)
// exampleArrList.Insert(3, "ogres are like onions");
// exampleArrList.Insert(0, -99);

//.remove(value) removes the first occurence of the item from the arraylist
// var newlist = new ArrayList()
// {
//   -10, 10, 15, -25, -10, 25, 33, -25, 40
// };
// Console.WriteLine(newlist[0]);
// newlist.Remove(-10);
// Console.WriteLine(newlist[0]);

//deleting based on index number
//.RemoveAt(value) deletes the item at specific index
// newlist.RemoveAt(4);

// //delete first item 
// newlist.RemoveAt(0);

// //delete last item;
// newlist.RemoveAt(newlist.Length - 1);

// //Remove an entire range of elements
// //.RemoveRange(firstIndexToDelete, LastIndexToDelete)
// newlist.RemoveRange(3,8)

// //shortcut to delete from one item through end of list
// newlist.RemoveRange(4, newlist.Length - 1);

//does the arraylist contain a vertain value
// .Contains(value) returns true if the list has that value, false otherwise
new playerInventory = new ArrayList()
  {
   "sword", "shield", "bazooka", "1-up power up", "death notebook", "potato"
  };

Console.WriteLine(playerInventory.Contains("fishing pole"));
Console.WriteLine(playerInventory.Contains("sword"));


   } //end
}