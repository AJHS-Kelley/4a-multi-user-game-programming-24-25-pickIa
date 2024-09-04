// data types and operators samuel jenkins, v0.0
using System;
class DataTypesOperators {
  static void Main() {
    // this is a note 
    /* still a comment
    */
    // float - float -- decimal numbers, +,- including 0.0
    // double - double -- decimal numbers +,- including 0.0 most common used 

    int myInteger = 1;
    double myDouble = 2.0D;
    //method 2 double And assign
    int myInteger2 = 1;
    double myDouble2 = 2.05D;

    //strings collectionsof letters numbers special characters

    string myString = "this is my string";

    //boolean true or false

    bool myBool = true;
    bool fireResistance = false;

    //character -- a single character

    char myChar = 'A';

    //assigning values after declaration

    myInteger = 5;
    myDouble = -1.0D;

    //printing variables to the console

    // Console.WriteLine(myInteger);
    // Console.WriteLine(myDouble);
    
    // Console.WriteLine(myInteger - 25);
    // Console.WriteLine(myDouble + 2.0D);
    


    int myNewInt = myInteger + myInteger2;
    double myNewdouble = myDouble + myDouble2;
    double myNewNumber =  myInteger + myDouble;

    // subtraction
    myNewNumber = myDouble - myInteger;

    // division
    myNewNumber = myDouble / myInteger;

    // multiplication
    myNewNumber = myDouble * myInteger;

    // modulus -- divides then returns the remainder
    myNewNumber = myDouble % 2;

    int students = 6;
    int numSlices = 36;
    int leftOvers;

    leftOvers = numSlices % students;

    //increment  / decrement
    int x = 0;
    x++;
    x--;
    // increment adds 1 and puts it in the bucket
    //decrement subtracts 1 and puts it in the bucket
    x += 1;
    x *= 1;
    x /= 1;
    x -= 1;
    x %= 1;
    //special assignment operators  takes current value, perform the calculation and put it in the bucket

    // comparisons operators
    int y = 5;
    int z = 3;

    // //is equal
    // Console.WriteLine(y == z);

    // // not equal to
    // Console.WriteLine(y != z);

    // // greater than
    // Console.WriteLine(y > z);

    // //greater than or equal to
    // Console.WriteLine(y >= z);

    // //less than or equal to
    // Console.WriteLine(y <= z);

    // // less than
    // Console.WriteLine(y < z);

    //logical operators
    int b = 1;
    double c = 2.0D;
    //logical and && all statements must be true
    // Console.WriteLine(b > 1 && c != 5.0D); // both are wrong so it is false
    // Console.WriteLine(b == 1 && c < 10.0D); //both are true so it is true
    // Console.WriteLine(hasPurpleKey == true && playerlevel > 5);

    //logical or || one statement must be true
    // Console.WriteLine(b > 1 || c != 5.0D); // one part is wrong one part is true so the whole thing is true
    // Console.WriteLine(b == 2 || c > 10.0D); // both parts are false so it is false
    //check for the most likely to be true statement first

    //logical Not ! returns the opposie value of the expression
    // Console.WriteLine(b > -1); //true
    // Console.WriteLine(!(b > -1)); //false

    //reading user input from the console/terminal
    // Console.WriteLine("What is your name? Type it and press enter.");
    // // create a variable to store the data
    // string playerName = Console.ReadLine();
    // //Console.ReadLine() only returns string data types

    // //print the variable to the screen
    // Console.WriteLine("Your player name is? " + playerName);
    
    // Console.WriteLine("Next, what is your favorite color? Type it and press enter");
    // string favColor = Console.ReadLine();
    // Console.WriteLine("Your favorite color is? " + favColor);

    // Console.WriteLine("What is your age? Type it and press enter. ");
    // string age = Console.ReadLine();
    // Console.WriteLine(age + age); //will print both numbers together, will not add them
    //adding string data types together is called concatenation

    //inputting numbers from the console
    Console.WriteLine("How many chicken nuggies can you eat? Enter an integer value and press enter.");
    int numNuggies = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("well i can eat");
    Console.WriteLine(numNuggies + numNuggies);

  }
}