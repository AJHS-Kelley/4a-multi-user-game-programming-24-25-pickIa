using System;
class FlowControlStructures {
  static void Main() {
    // These blocks of code are used to control how the program executes.
    // basically these blocks of codea allow for decisions to be made

    // int age = 17;
    double cheeseBurgers = 1.25D;
    string favFlavor = "Butterscotch";
    bool afrainSnakes = false;

    //can i vote?
    // if (age >= 18) // (age >= 18 is the conditional statement)
    // {
    //   Console.WriteLine("You can vote!\n");
    // }
    // else if (age >= 16) //check this next if line 13 is false
    // {
    //   Console.WriteLine("You cant vote but you can register.\n");
    // }
    // else
    // {
    //   Console.WriteLine("You cannot vote or register yet.\n");
    // }
    
    /*
    you can have a single if statement by itself
    if you have an else you must also have an if
    you can have as many else if statements as needed
    for now use the else condition to print error messages or logs

    */
    int age = 5;
    if (age >= 0) {
      Console.WriteLine("Age data stored.\n");
    }
    else {
      Console.WriteLine("No age value detected. please review. \n");
    }

  //switch statements
  int day = 1;
  switch(day)
  {
    case 1:
     Console.WriteLine("its monday.\n");
     break;
    case 2:
      Console.WriteLine("its tuesday. \n");
     break;
    case 3:
      Console.WriteLine("its wednesday. \n");
      break;
    // case 4 - 6
    case 7:
      Console.WriteLine("its sunday, go rest. \n");
      break;
  }
  
  //repeating steps over and over and over again
  // loops are used to repeat instructions multiple times
  //while loops are "music chairs" in computer science
  //the code will run as long as the condition is true
  /* while (conditional_expression)
  {
    code to loop goes here
  
  }
  */
  int z = 0;
  while (z > 100) //what do i replace conditional expression with
  {
    Console.WriteLine(z);
    z++;
  }
  int y = 100;
  // while (y >= 0)
  // {
  //   Console.WriteLine(y);
  //   y--; 
  // }
  //for loops are like playing go fish
  //you know how many cards are in your hand
  //used when you know how many loops you need ahead of time
  /*
  for (statement1; statement2; statement3)
  {
    code to run each time through loop
  }

  statement 1 = code to run one time before the loop starts
  statement 2 == conditional expression to check each time before loop runs
  statement 3 = code to run after each loop
  each trip through the loop is called an iteration */

  //counting to 10 with for loops
  for (int i = 0; i <= 10; i++)
  {
    Console.WriteLine(i);
  }
  for (int i = 10; i >= 0; i--)
  {
    Console.WriteLine(i);
  }
  //line for a reason
  
  }
}