public static class Arrays
{
    /// <summary>
    /// This function will produce an array of size 'length' starting with 'number' followed by multiples of 'number'.  For 
    /// example, MultiplesOf(7, 5) will result in: {7, 14, 21, 28, 35}.  Assume that length is a positive
    /// integer greater than 0.
    /// </summary>
    /// <returns>array of doubles that are the multiples of the supplied number</returns>
    public static double[] MultiplesOf(double number, int length)
    {
        // TODO Problem 1 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.

        // Step 1: Create an array that can hold 'length' number of items
        double[] result = new double[length];

         // Step 2: Loop from 0 to length - 1
        for (int i = 0; i < length; i++)
        {
            // Step 3: Multiply the number by (i + 1) to get the correct multiple
            // For example, if number = 3, i = 0, then result[0] = 3 * 1 = 3
            result[i] = number * (i + 1);
        }

        // Step 4: Return the filled array
;
    

        return result; // replace this return statement with your own
    }

    /// <summary>
    /// Rotate the 'data' to the right by the 'amount'.  For example, if the data is 
    /// List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9} and an amount is 3 then the list after the function runs should be 
    /// List<int>{7, 8, 9, 1, 2, 3, 4, 5, 6}.  The value of amount will be in the range of 1 to data.Count, inclusive.
    ///
    /// Because a list is dynamic, this function will modify the existing data list rather than returning a new list.
    /// </summary>
    public static void RotateListRight(List<int> data, int amount)
    {
        // TODO Problem 2 Start
        // Remember: Using comments in your program, write down your process for solving this problem
        // step by step before you write the code. The plan should be clear enough that it could
        // be implemented by another person.
        
        // Step 1: Find the split index (where the rotation starts)
        int splitIndex = data.Count - amount;

        // Step 2: Get the last 'amount' elements that will move to the front
        List<int> lastPart = data.GetRange(splitIndex, amount);

        // Step 3: Get the first part (from the start to the split)
        List<int> firstPart = data.GetRange(0, splitIndex);

        // Step 4: Clear the original list
        data.Clear();

        // Step 5: Add the last part (rotated section) first
        data.AddRange(lastPart);

        // Step 6: Add the first part after it
        data.AddRange(firstPart);
    }
}
