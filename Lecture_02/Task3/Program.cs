// See https://aka.ms/new-console-template for more information
// Task 3
// Write a code that inserts the value of zero to the elements on the left side
// of the main diagonal into an array-matrix of arbitrary size, and a value of one to the right.
// The initial matrix should be declared and filled in the code.
// Write the result to another variable - an array of the same size
// as the original one, without modifying the original one.

int[,] Create2DArray()
{
    int[,] array2D =
    {
        { 9, 1, 2, 5 },
        { 3, 4, 5, 6 },
        { 6, 7, 8, 89 },
        { 20, 1, 43, -1 },
    };

    return array2D;
}

void Print2DArray(int[,] arr)
{
    if (arr == null)
        return;

    Console.WriteLine("=== OUTPUT 2D ARRAY ===");
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] Transform2DArray(int[,] sourceArray)
{
    if (sourceArray == null)
        return null;

    int[,]? copyArray = sourceArray.Clone() as int[,];

    for (int i = 0; i < copyArray.GetLength(0); i++)
    {
        for (int j = 0; j < copyArray.GetLength(1); j++)
        {
            // below diagonal
            if (i != j && i > j)
            {
                copyArray[i, j] = 0;
            } // above diagonal
            else if (i != j && i < j)
            {
                copyArray[i, j] = 1;
            }
        }
    }

    return copyArray;
}

int[,] array2D = Create2DArray();
Print2DArray(array2D);

int[,] transformedArray = Transform2DArray(array2D);
Print2DArray(transformedArray);

Console.ReadKey();
