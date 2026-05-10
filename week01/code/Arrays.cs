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

      // PLAN:
    // 1. I need to return an array of doubles containing "length" multiples of "number".
    // 2. The first element should be 1 * number, the second 2 * number, ..., up to length * number.
    // 3. Create a new double array with size = length.
    // 4. Use a for-loop from i = 0 to i < length.
    // 5. For each index i, compute the (i + 1)-th multiple: (i + 1) * number.
    // 6. Store that value in the array at position i.
    // 7. After the loop finishes, return the filled array.

    // Step 3: create the result array
    var result = new double[length];

    // Steps 4–6: fill it with multiples of "number"
    for (int i = 0; i < length; i++)
    {
        result[i] = (i + 1) * number;
    }

    // Step 7: return the array
    return result;
      
      
      

      
        
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
   
   
   // PLAN:
    // 1. Understand what "rotate right by amount" means:
    //    - The last 'amount' elements of the list move to the front.
    //    - The remaining elements shift to the right after them.
    //
    //    Example: data = [1,2,3,4,5,6,7,8,9], amount = 3
    //    - Last 3 elements: [7,8,9]
    //    - First part: [1,2,3,4,5,6]
    //    - Result: [7,8,9,1,2,3,4,5,6]
    //
    // 2. Since the list is dynamic and we must modify it in place (not return a new list),
    //    we need to rearrange the existing elements.
    //
    // 3. Compute the index where the "split" happens:
    //    - splitIndex = data.Count - amount
    //    - Elements from splitIndex to end are the ones that move to the front.
    //
    // 4. Create a temporary list to store the last 'amount' elements:
    //    - tail = elements from splitIndex to data.Count - 1
    //
    // 5. Remove those last 'amount' elements from the original list.
    //
    // 6. Insert the saved 'tail' elements at the beginning of the list (in the same order).
    //
    // 7. After these steps, 'data' should be rotated right by 'amount' as required.

    // IMPLEMENTATION:

    // Step 3: compute split index
    int splitIndex = data.Count - amount;

    // Step 4: copy the last 'amount' elements
    List<int> tail = data.GetRange(splitIndex, amount);

    // Step 5: remove those elements from the end
    data.RemoveRange(splitIndex, amount);

    // Step 6: insert them at the front
    data.InsertRange(0, tail);
   
   
   

   
    }
}
