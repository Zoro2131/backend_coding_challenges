
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
int[] integerInput = new int[] {3, 5, 7, 2, 8, 15, 30, -12, -5};

//declaring classes for Max and Min
FindMaxInArray findMaxInArray = new FindMaxInArray();
FindMinInArray findMinInArray = new FindMinInArray();

//declares and initializes the resultValue to the Max in the intergerInput
int resultValue = findMaxInArray.FindMaxProcess(integerInput);

System.Console.WriteLine(resultValue);
System.Console.WriteLine();

resultValue = findMinInArray.FindMinProcess(integerInput);
System.Console.WriteLine(resultValue);
System.Console.WriteLine();


//CountVowels
CountVowels countVowels = new CountVowels();
int totalVowelsCount = countVowels.CountingVowelsProcess(aString);
System.Console.WriteLine(totalVowelsCount);
System.Console.WriteLine();

//FindAverage
FindAverage findAverage = new FindAverage();
double findAverageResult = findAverage.FindAverageProcess(integerInput);
System.Console.WriteLine(findAverageResult);
System.Console.WriteLine();

//CountEvenNumbers
CountEvenNumbers countEvenNumbers = new CountEvenNumbers();
int countEvenNumbersResult = countEvenNumbers.CountEvenNumbersProcess(integerInput);
System.Console.WriteLine(countEvenNumbersResult);
System.Console.WriteLine();