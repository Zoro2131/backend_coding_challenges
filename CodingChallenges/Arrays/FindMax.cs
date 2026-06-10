// Find Max Number in Array
// Write a function that takes an array of integers as input and returns the maximum number in the array.
// Example:
// Input: [3, 5, 7, 2, 8]
// Output: 8

namespace CodingChallenges.Arrays;


public class FindMaxInArray
{
    //This method returns the Max number in an interger Array
    //Return Type: interger
    //Param input:  int array
    public int FindMaxProcess(int[] findMaxInput)
    {
        //setting to the first index in the arrary and will be replace next highest int in the array as we loop
        int currentMax = findMaxInput[0];

        //loops to the lenght of the array input
        //indexs up
        for (int i = 0; i < findMaxInput.Length; i++)
        {
            //preforms a check at the current index location
            // to see if currentMax is less then the index value
            if(currentMax < findMaxInput[i])
            {
                //if yes we say currentMax = the value at index location
                currentMax = findMaxInput[i];
            }
        }
        // return the highest value in the array after the loop
        return currentMax;
    }
}