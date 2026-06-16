
//lets you access namespaces from CodingChallenges
using System.Runtime.InteropServices;
using CodingChallenges.Arrays;
using CodingChallenges.Strings;
using RtsCombatExamples.Models;
using RtsCombatState.Factory;
using RtsCombatState.Models;
using RtsUnitExample.Models;




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

//Rts Example Unit Print
MakeUnitDefinition makeUnitDefinition = new();
UnitDefinition recruitDefinition = makeUnitDefinition.Recruit();
System.Console.WriteLine(recruitDefinition.Name);
System.Console.WriteLine(recruitDefinition.ActiveSkill.Name);
System.Console.WriteLine(recruitDefinition.PassiveSkill.Name);

MakeCombatStates makeCombatStates = new();
BaseCombatState neutralState = makeCombatStates.NeutralState();
System.Console.WriteLine(neutralState.Name);

UnitPosition startingPosition = new()
{
    X_Position = 30.0,
    Y_Position = 30.0,
    ZoneID = 1
};

MakeUnitInstance makeUnitInstance = new();
UnitInstance recruit = 
    makeUnitInstance.CreateUnit(
        recruitDefinition,
        neutralState,
        startingPosition
    );
System.Console.WriteLine(recruit.UnitDefinition.Name);
Console.WriteLine(recruit.CurrentHealth);
Console.WriteLine(recruit.CurrentState.Name);
Console.WriteLine(recruit.UnitDefinition.ActiveSkill.Name);
Console.WriteLine(recruit.UnitDefinition.PassiveSkill.Name);
Console.WriteLine(recruit.UnitDefinition.ActiveSkill.CombatEffect.Name);