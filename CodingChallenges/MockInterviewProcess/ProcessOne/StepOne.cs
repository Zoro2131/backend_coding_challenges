// Senior Software Engineer (Interviewer):

// Hi James, thanks for taking the time to meet today. We'll start with a coding exercise. Feel free to think out loud as you work—I'm interested in your reasoning just as much as your final solution.

// Problem 1 — Two Sum

// Given an array of integers nums and an integer target, return the indices of the two numbers that add up to the target.

// Example:

// nums = [2, 7, 11, 15]
// target = 9

// Output:
// [0, 1]

// Assumptions:

// There is exactly one valid answer.
// You may not use the same element twice.
// Return the indices, not the values.
// Before you start coding

// Walk me through:

// How do you understand the problem?
// My understanding of the problem is that i get a array of different numbers and i need to check i each index and add it to another 
// index and compare that to the targeted outcome to see if it is equal to it then return the indexs that = true to the projected outcome
// Are there any clarifying questions you'd ask?
// not at the moment
// What is your initial approach?
// my approch prolly a nested for loop with an if statement 
// What do you think the time complexity of that approach would be?
// bigO prolly slower then a dictonary that should be able to do it as well 




namespace CodingChallenges.MockInterviewProcess.ProcessOne
{

    class ProblemOne
    {
        readonly List<int> Nums = new List<int> {2, 7, 11, 15};
        readonly int Target = 9;
        List<int> Result = new List<int>();

        public List<int>? StepOne(List<int> Nums)
        {
           for (int i = 0; i < Nums.Count; i++)
           {
                for (int j = i + 1; j < Nums.Count; j++)
                {
                    if(Nums[i] + Nums[j] == Target)
                    {
                        Result.Add(i);
                        Result.Add(j);
                        return Result;
                    }
                    
                }
            }
            return null;
        }
    };
}

