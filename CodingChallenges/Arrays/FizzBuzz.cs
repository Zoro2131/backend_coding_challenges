using System;

//Use namespace to get access to this function in main
namespace CodingChallenges.Arrays;

//What is FizzBuzz?
//FizzBuzz is a simple programming problem that is often used as a coding challenge or interview question. 
//The task is to print the numbers from 1 to a given limit, but for multiples of 3, print "Fizz" instead of the number, 
//for multiples of 5, print "Buzz", and for multiples of both 3 and 5, print "FizzBuzz".
//
//1–100

//Divisible by 3 → Fizz
//Divisible by 5 → Buzz
//Both → FizzBuzz
//Else → number

// Remember:
// A class cannot contain executable code directly.
// Classes declare:
// - Fields
// - Properties
// - Methods (behavior/actions)
// - Constructors
// - Interfaces
// - Constants/static members
// - Other classes 
public class FizzBuzz
{

    // Method/action used to print numbers

    // Parameter definition is and input variable passed into a method
    // Parameter:
    // numberSeq is an int array passed into the method 
    public void PrintNumbers(int[] numberSeq)
    {
        foreach (int num in numberSeq)
        {   
            //Remember top down logic
            if(num % 3 == 0 && num % 5 == 0)
            {
                System.Console.WriteLine("FizzBuzz");
            }
            else if(num % 5 == 0)
            {
                System.Console.WriteLine("Buzz");
            }
            else if(num % 3 == 0)
            {
                System.Console.WriteLine("Fizz");
            }
            else
            {
                System.Console.WriteLine(num);
            }
        }
    }
}