/// <summary>
/// Write a function that take in bracket pairs as an argument that will return true if the bracket pairs are balanced and false if not. 
/// </summary>

public class BalancedBracketProblem
{
    public static void Main(string[] args)
    {
        /// <summary>
        /// Will log the result of IsBalanced
        /// </summary>
        /// <value>string of bracket pairs</value>
        Console.WriteLine(IsBalanced("{{([])}}").ToString());
        Console.WriteLine(IsBalanced("(((}]").ToString());
    }
    /// <summary>
    /// Takes in inputBrackets and checks if they match
    /// </summary>
    /// <param name="inputBrackets"></param>
    /// <returns>true if brackets match up</returns>
    private static bool IsBalanced(string inputBrackets)
    {
        // Initialize a stack to hold open and close brackets
        Stack<char> openingBrackets = new Stack<char>();
        Stack<char> closingBrackets = new Stack<char>();
        // Loop input brackets
        foreach (char item in inputBrackets)
        {
            // If item is an opening bracket push it to openBrackets
            if (item == '{' || item == '(' || item == '[')
            {
                openingBrackets.Push(item);
            }
        }
        // Loop inputBrackets backwards
        for (int i = inputBrackets.Length - 1; i >= 0; i--)
        {
            // If char is closing bracket push it to closingBrackets
            if (inputBrackets[i] == '}' || inputBrackets[i] == ')' || inputBrackets[i] == ']')
            {
                closingBrackets.Push(inputBrackets[i]);
            }
        }
        // Check if the stack counts are not even
        if ((closingBrackets.Count + openingBrackets.Count) % 2 != 0)
        {
            // Return false if stacks are not even the brackets cannot match
            return false;
        }
        // Loop while the openingBrackets.Count != 0
        while (openingBrackets.Count != 0)
        {
            // Init vars to hold an open and close bracket
            char currentOpenBrace = openingBrackets.Pop();
            char currentClosingBrace = closingBrackets.Pop();
            // Check to see if the two vars match each other
            if ((currentClosingBrace == '}' && currentOpenBrace == '{') || (currentClosingBrace == ')' && currentOpenBrace == '(') || (currentClosingBrace == ']' && currentOpenBrace == '['))
            {
                // If so continue to next iteration
                continue;
            }
            else
            {
                // If no match then return false
                return false;
            }
        }
        // If while loop finishes without returning false all brackets have an opening and closing partner so return true
        return true;
    }
}
