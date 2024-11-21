using System;
class Strings {
  static void Main() {
    //in c# all strings must use double quotes "  "

    string greeting = "Hello, hi, hello. \n";
    string goodbye = "stay safe \n";

    //in c# strings are treated like an oject that has properties and methods
    //properties are thngs that describe the object such as length, values, data type etc
    //methods are build in functions related to that object

    //length is an important property for strings
    Console.WriteLine(greeting.Length);
    Console.WriteLine(goodbye.Length);

    if (greeting.Length > goodbye.Length)
    {
      Console.WriteLine("The greeting is longer than the goodbye");
    }

    //useful string methods

    Console.WriteLine(greeting.ToUpper());
    Console.WriteLine(greeting.ToLower());
    
    //string concatenation 
    string comboString = greeting + goodbye;
    Console.WriteLine(comboString);

    //string concatenation 2
    string comboString2 = string.Concat(greeting, goodbye);
    Console.WriteLine(comboString2);

    //string interpolation -- substititing variables into strings
    string comboString3 = $"My Greeting is {greeting} and my goodbye is {goodbye}";
    Console.WriteLine(comboString3);

    //substituting variables into strings methos 2
    Console.WriteLine("my greeting is " + greeting + "and my goodbye is " + goodbye + "\n");

    //accessing parts of strings
    //index is a specific location of a characer in a string
    //all string indexes start at 0
    Console.WriteLine(goodbye[0]); //print the character at index 0
    Console.WriteLine(goodbye[4]); //replace x with what to print the 5th char?
    
    //where is it in my string?
    Console.WriteLine(greeting.IndexOf("y"));

    //finding parts of a string
    string fullName = "billy mays";

    //what letter?
    int lastInitial = name.IndexOf("M");

    //find the sub
    string lastName = fullName.substring(LastInitial);

    //print it
    Console.WriteLine(lastName);
      }
}