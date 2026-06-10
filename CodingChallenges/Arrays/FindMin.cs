// Find Min Number in Array
// Write a function that takes an array of integers as input and returns the maximum number in the array.
// Example:
// Input: { 3, 8, 2, 10, 5 };
// Output: 8

namespace CodingChallenges.Arrays;

public class FindMinInArray
{
    //This method returns the lowest number in an interger Array
    //Return Type: interger
    //Param input:  int array
    public int FindMinProcess(int[] findMinInput)
    {
        //setting to the first index in the arrary and will be replace next highest int in the array as we loop
        int currentMin = findMinInput[0];

        //loops to the lenght of the array input
        //indexs up
        for (int i = 0; i < findMinInput.Length; i++)
        {
            //Checks to see if the Current Assing lowest number is greater then 
            //the value at index i 
            if(currentMin > findMinInput[i])
            {
                //if yes reassign to the value at i which will be lower'
                currentMin = findMinInput[i];   
            }
        }
        //return the lowest value in the array
        return currentMin;
    }
}