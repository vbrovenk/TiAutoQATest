// See https://aka.ms/new-console-template for more information
// Task 4
// Implement a Game of Life. 

// create GRID manually
int[,] MakeGrid()
{
    int[,] grid =
    {
        { 1, 0, 1 },
        { 0, 0, 0 },
        { 0, 1, 0 },
        { 0, 0, 0 }
    };

    return grid;
}

int[,] MakeRandomGrid(int rows, int columns)
{
    int[,] grid = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            grid[i, j] = rnd.Next(2);

    return grid;
}

void PrintGrid(int[,] grid)
{
    Console.Clear();
    Console.WriteLine("Press ANY key for next step.");

    for (int i = 0; i < grid.GetLength(0); i++)
    {
        Console.Write((grid.GetLength(0) - i) + " ");
        for (int j = 0; j < grid.GetLength(1); j++)
        {
            if (grid[i, j] == 1)
                Console.Write("+ ");
            else
                Console.Write("- ");
        }
        Console.WriteLine();
    }

    for (int i = 0; i <= grid.GetLength(1); i++)
    {
        Console.Write(i + " ");
    }

    Console.WriteLine();
}

int CountAliveNeighbours(int x, int y, int[,] currentGrid)
{
    int sumNeighbours = 0;

    for (int i = -1; i <= 1; i++)
    {
        for (int j = -1; j <= 1; j++)
        {
            // don't count itself
            if (i == 0 && j == 0)
                continue;
            // if alive neighbour exists in a range of GRID
            if (-1 < x + i && x + i < currentGrid.GetLength(0) &&
                -1 < y + j && y + j < currentGrid.GetLength(1))
            {
                if (currentGrid[x + i, y + j] == 1)
                    sumNeighbours += 1;
            }
        }
    }

    return sumNeighbours;
}

// return game status
bool CalculateNextGen(ref int[,] currentGrid)
{
    int amountOfNeighbours;
    int[,] nextGenGrid = currentGrid.Clone() as int[,];
    int countChanges = 0;
    int countAliveCells = 0;


    // go throug every cell
    for (int i = 0; i < currentGrid.GetLength(0); i++)
    {
        for (int j = 0; j < currentGrid.GetLength(1); j++)
        {
            amountOfNeighbours = CountAliveNeighbours(i, j, currentGrid);

            // cell with one or no neighbors dies, as if by solitude.
            if (currentGrid[i, j] == 1 && amountOfNeighbours < 2)
            {
                nextGenGrid[i, j] = 0;
                countChanges += 1;
            }


            // cell with four or more neighbors dies, as if by overpopulation.
            if (currentGrid[i, j] == 1 && amountOfNeighbours > 3)
            {
                nextGenGrid[i, j] = 0;
                countChanges += 1;
            }

            // Each cell with three neighbors becomes populated.
            if (currentGrid[i, j] == 0 && amountOfNeighbours == 3)
            {
                nextGenGrid[i, j] = 1;
                countChanges += 1;
            }


            countAliveCells += nextGenGrid[i, j];
        }
    }

    currentGrid = nextGenGrid;

    // condition for end of game
    if (countChanges == 0 || countAliveCells == 0)
    {
        PrintGrid(currentGrid);
        Console.WriteLine("==== GAME OVER ====");
        return false;
    }

    return true;
}

int[,] grid = MakeRandomGrid(5, 9);

PrintGrid(grid);
Console.ReadKey();

while (CalculateNextGen(ref grid))
{
    PrintGrid(grid);
    Console.ReadKey();
}

Console.ReadKey();


