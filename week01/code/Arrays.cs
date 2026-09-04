using System;
using System.Collections.Generic;

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
        // Step 1: Create a new double array with a size equal to 'length'.
        // Step 2: Set up a loop running from 0 up to 'length - 1'.
        // Step 3: For each iteration 'i', calculate the multiple using: number * (i + 1).
        //         This ensures index 0 gets (number * 1), index 1 gets (number * 2), etc.
        // Step 4: Assign the calculated product into the array at index 'i'.
        // Step 5: Return the completed array.

        double[] multiples = new double[length];

        for (int i = 0; i < length; i++)
        {
            multiples[i] = number * (i + 1);
        }

        return multiples;
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
        // Step 1: Check if the list is empty or if rotating by 'amount' results in no net change 
        //         (e.g., rotating a list of size 9 by 9 results in the original list). If so, exit early.
        // Step 2: Determine the starting index for the sublist that needs to move to the front.
        //         The elements moving to the front are the last 'amount' elements, starting at index (data.Count - amount).
        // Step 3: Extract these last 'amount' elements using GetRange(startingIndex, count).
        // Step 4: Remove the extracted elements from the end of the list using RemoveRange(startingIndex, count).
        // Step 5: Insert the extracted slice back into the list at index 0 using InsertRange(0, slice).

        if (data == null || data.Count == 0 || amount == data.Count)
        {
            return;
        }

        int startIndex = data.Count - amount;

        List<int> slice = data.GetRange(startIndex, amount);

        data.RemoveRange(startIndex, amount);

        data.InsertRange(0, slice);
    }
}