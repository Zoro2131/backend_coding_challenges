// Senior Software Engineer (Interviewer)

// Hi James, welcome back. Today we'll continue with another coding exercise.

// As before, I'm interested in how you think, not just whether you arrive at the answer.

// Remember to:

// Think out loud.
// Ask clarifying questions if you have them.
// Explain your approach before writing code.

// I'll mostly listen and only step in if you ask for a hint or get stuck.

// Problem 2 — Valid Parentheses

// Given a string containing only these characters:

// ( ) { } [ ]

// Determine if the string is valid.

// A string is valid if:

// Every opening bracket has a matching closing bracket.
// Brackets close in the correct order.
// Every closing bracket has a corresponding opening bracket.
// Examples
// Input: "()"
// Output: true
// Input: "()[]{}"
// Output: true
// Input: "(]"
// Output: false
// Input: "([)]"
// Output: false
// Input: "{[]}"
// Output: true
// Before you write any code

// Walk me through:

// How do you understand the problem?
//My UnderStanding of the problem 
//first i need to find in a string if it has a valid starting bracket element (, {, or [
//then iterate through to the end of that string to check if it has a corrasponding closing element
// while also checking if there is a nested starting element then a nested closing element
// i will also need to check if their correctness and order
// then return true
// Do you have any clarifying questions?
// im looking at some documetation from here 
//https://dev.to/thedsdev/data-structures-in-c-a-beginners-guide-mastering-16ak
// and here https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.dictionary-2?view=net-10.0
// yes i have one question could a queue be used to preform a check if i assign a var to the starting element then if it hit add it to the que, im asking because im not sure what data structure to use
// a dictonary might work if i check if the first is a starting element the loop the string in the to the next key
// i would have to set the key to the (), {}, [] element and to check if is in order
// What is your initial approach?
// i think the dictornay approch would be best 
// What data structure do you think might help here?
// What do you think the time complexity of your approach will be?
// it would be O(1)

// One note: This problem is less about loops and more about choosing the right data structure. Don't worry if you haven't used it much before—I'm interested in your reasoning.

namespace CodingChallenges.MockInterviewProcess.ProcessOne
{
    
    class ProblemTwo
    {
        //mapping the Keys to the brackets types 
        Dictionary<char, char> KeyElements = new Dictionary<char, char>
        {
            { ')', '(' },
            { '}', '{' },
            { ']', '[' },
        };

        //declares a Stack to add elements too.
        Stack<char> ElementStack = new Stack<char>();

        public bool InputString(string input)
        {
            
            for (int i = 0; i < input.Length; i++)
            {
                //checks to see if the index is a value in the dict 
                //the string input should start with a value(witch is an opening bracket element)
                if(KeyElements.ContainsValue(input[i]))
                {
                    //if so add to the stack
                    ElementStack.Push(input[i]);
                }
                // finds the closing bracket
                else if (KeyElements.ContainsKey(input[i]))
                {


                    //if stack is empty return false
                    if(ElementStack.Count == 0)
                    {
                        return false;
                    }

                    //get the top item from the stack 
                    var firstElement = ElementStack.Peek();

                    //compare the top to the current input[i]
                    if(firstElement != KeyElements[input[i]] )
                    {
                        //if not the same return false
                        return false;
                    }
                    // if they match pop the top and that will move the next top so we can check the next closing to it 
                    ElementStack.Pop();
                }
            }

            if(ElementStack.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            } 
        }
    }
}