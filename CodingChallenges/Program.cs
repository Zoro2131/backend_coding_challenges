

//FizzBuzz
//lets you access Arrays from CodingChallenges
using CodingChallenges.Arrays;
//declares and int array fizzBuzzInput 
//uses the Linq in c# to make a range 1 to 100 and cast that using ToArray 
 int[] fizzBuzzInput = Enumerable.Range(1,100).ToArray();

 //Declare an instance/object of FizzBuzz Class
 FizzBuzz fizzBuzz = new FizzBuzz();

//object.method(parameter)
//Uses the new FizzBuzz object we just created 
//call the method/action availbe in the class
//inputs the parameter for that type we said it requied in method creation
FizzBuzz.PrintNumbers(fizzBuzzInput);
