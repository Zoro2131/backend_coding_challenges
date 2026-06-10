namespace CodingChallengs.Strings;

//A class that will return the amount of vowels in an string input
public class CountVowels
{
    //method that takes in a string and loops it
    //then returns the total amount of vowels that the string array contains
    public int CountingVowelsProcess(string vowelCountingInput)
    {
        //declare and int and initializing to 0 
        //to use for the total vowels in the string
        int totalVowels = 0;

        //string normalization
        string normalizedVowelCountingInput = vowelCountingInput.ToLower();

        //declares a string with all of the vowels so we can make conditional checks
        //on the vowelCountingInput

        //Note: we could also do this with a switch Statement
        //and not use the nested for loop method
        string vowels = "aeiou";

        //Loop to cycle through the string
        //compares the vowelCountingInput indexes to the vowels indexes
        for (int i = 0; i < normalizedVowelCountingInput.Length; i++)
        {
            for (int j = 0; j < vowels.Length; j++)
            {
                if(normalizedVowelCountingInput[i] == vowels[j])
                {
                    totalVowels ++;
                }
            }
        }

        //then returns the total amount of vowels contained in the input string
        return totalVowels;
    }
}