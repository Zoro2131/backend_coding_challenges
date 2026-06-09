// Reverse String
// Write a function that takes a string as input and returns the string reversed.
// Example:
// Input: "hello"
// Output: "olleh"

namespace CodingChallenges.Strings;


public class ReverseString
{
    // The actions/methods need to return the same type in this case its a String 
    public string ReverseProcess(string input)
    {

        string result = "";

        // String can be index like an array
        //input[i] returns the character at index i
        for(int i = input.Length - 1; i >= 0 ; i--)
        {
            //Remember the [] here act as accessor for the value passed in at that index
            result += input[i];
        }
        return result;
    }
}
