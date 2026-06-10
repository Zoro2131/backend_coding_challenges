namespace CodingChallenges.Arrays;

public class CountEvenNumbers
{
  public int CountEvenNumbersProcess(int[] evenNumberInput)
    {
        int totalEvenNumbersCount = 0;

        foreach(int number in evenNumberInput)
        {
            if(number % 2 == 0)
            {
                totalEvenNumbersCount++;
            }
        }
        return totalEvenNumbersCount;
    }  
}