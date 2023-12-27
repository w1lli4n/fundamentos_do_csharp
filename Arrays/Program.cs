using System;

internal class Program
{
    private static void Main(string[] args)
    {
        var newArray = new int[5];  // arrays...
        string[] otherArray = { "1", "2", "3", "4", "5", "6", "7" };  // syntax ok

        for (short i = 0; i < newArray.Length; i++)
        {
            Console.Write($"{i}: {newArray[i]}; ");    // arrays...
        }

        foreach (var item in otherArray)
        {
            Console.Write($"{item}, ");    // foreach, tem suas vantagens e desvantagens
        }

        // arrays em c# ficam na heap, são utilizados primariamente por referencias mutaveis. WARNING!

        int[] firstArray = {1, 2, 3};
        int[] secondArray = firstArray;

        secondArray[0] = 10;

        Console.WriteLine(secondArray[0]);
        Console.WriteLine(firstArray[0]);
    }
}