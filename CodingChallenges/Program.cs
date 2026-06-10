
//lets you access namespaces from CodingChallenges
using CodingChallenges.Arrays;
using CodingChallenges.Strings;


//FizzBuzz

//declares and int array fizzBuzzInput 
//uses the Linq in c# to make a range 1 to 100 and cast that using ToArray 
 int[] fizzBuzzInput = Enumerable.Range(1,100).ToArray();
 
 //Declare an instance/object of FizzBuzz Class
 FizzBuzz fizzBuzz = new FizzBuzz();

//object.method(parameter)
//Uses the new FizzBuzz object we just created 
//call the method/action availbe in the class
//inputs the parameter for that type we said it requied in method creation
fizzBuzz.PrintNumbers(fizzBuzzInput);
System.Console.WriteLine();

//Reverse String 

 //Declare and instance of ReverseString Class
 ReverseString reverseString = new ReverseString();

//A string to pass in to ReverseString
 String aString = "Hello My Name is James Carter.";

 string reversed = reverseString.ReverseProcess(aString);

 System.Console.WriteLine(reversed);
 System.Console.WriteLine();


//FindMax/FindMin
//declare and int array
int[] intergerInput = Array[3, 5, 7, 2, 8, 15, 30, -12, -5];

//declaring classes for Max and Min
FindMaxInArray findMaxInArray = new FindMaxInArray();
FindMinInArray findMinInArray = new FindMinInArray();

//declares and initializes the resultValue to the Max in the intergerInput
int resultValue = findMaxInArray.FindMaxProcess(intergerInput);

System.Console.WriteLine(resultValue);
System.Console.WriteLine();

resultValue = findMinInArray.FindMinProcess(intergerInput);
System.Console.WriteLine(resultValue);
System.Console.WriteLine();

