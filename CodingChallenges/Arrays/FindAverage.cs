namespace CodingChallenges.Arrays;

public class FindAverage
{

    public double FindAverageProcess(int[] findAverageInput)
    {

        //declares and initializes the default interger values for 
        //totalAddedValue and indexCounter
        double totalAddedValue = 0;

        //Note: you want the whole length of the array so <= will traverse the full array lenght 
        //< would not hit the last 
        // and if i did .lenght -1 it would not hit the last and 
        for (int i = 0; i < findAverageInput.Length ; i++)
        {
            totalAddedValue += findAverageInput[i];
        }

        double result = (totalAddedValue / findAverageInput.Length);
        
        // returns the total value / the the array length for the total amount of values 
        return result;
    }
}