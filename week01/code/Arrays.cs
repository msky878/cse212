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

        // 1. first i must understand what should this function return - 'lenght' amount of multiples of the 'number'
        // 2. then i am thinking how would i do this for example on paper - i'd take the 'number' and multiply it by 1, 2, 3 ... up to the 'lenght'
        // 3. then i'd take these numbers and write them down in a sequence
        // 4. now transalte this into C#: i will create a loop that will increment a variable with each iteration, i will then multiply the 'number' by that variable, inserting the result into a the array

        double[] result = new double[length];

        for (int i = 1; i <= length; i++)
        {
            result[i - 1] = number * i; // array is indexed from 0 but we start from 1 hence i-1
        }

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

        // 1. first understading the result - i must move all elements to the right 'amount' times
        // 2. moving by 1 equals taking the last element and putting him before the rest / making him first
        // 3. so doing it X times equals taking last X elements and making them first
        // 4. so now i just need to take 'amount' elements from the end, and the rest (the beginning of the list up to the 'amount'th element)
        // 5. and rotate them

        List<int> firstHalf = data.GetRange(0, data.Count - amount);
        List<int> secondHalf = data.GetRange(data.Count - amount, amount);

        data.Clear();
        data.AddRange(secondHalf);
        data.AddRange(firstHalf);
    }
}
