// See https://aka.ms/new-console-template for more information
// Task 2
// Write code that swaps the first and last values in the array, the second and penultimate values, and so on.
// Example: (10, 5, 3, 4) => (4, 3, 5, 10). Array input and output can be done from the console.

using System.Drawing;

void PrintArray(int[] arr, string text)
{
    Console.Write(text + ": ");
    foreach (int nbr in arr)
    {
        Console.Write(nbr + " ");
    }

    Console.WriteLine();
}

int ParseStringToInt()
{
    int result = 0;

    while (!int.TryParse(Console.ReadLine(), out result))
    {
        Console.WriteLine("Invalid data! Try again: ");
    }

    return result;
}

int[] InputArray()
{
    int sizeNewArray = 0;
    int[] arrayInts;

    Console.WriteLine("Input a size for new Array: ");
    sizeNewArray = ParseStringToInt();

    arrayInts = new int[sizeNewArray];
    Console.WriteLine("Input elements for new Array: ");
    for (int i = 0; i < sizeNewArray; i++)
    {
        arrayInts[i] = ParseStringToInt();
    }

    return arrayInts;
}

void SwapElementsInArray(int[] inputArray)
{
    int lengthArray = inputArray.Length;

    for (int i = 0; i < lengthArray / 2; i++)
    {
        int temp = inputArray[i];
        inputArray[i] = inputArray[lengthArray - i - 1];
        inputArray[lengthArray - i - 1] = temp;
    }

}

int[] newArr = InputArray();

PrintArray(newArr, "Source array");
SwapElementsInArray(newArr);
PrintArray(newArr, "After swaping");

Console.ReadKey();