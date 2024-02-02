// Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] CreateRandomMatrix(int lines, int columns, int min, int max)
{
    int[,] matrix = new int[lines, columns];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max);
        }
    }
    return matrix;
}

int[,] IvenIndexesInSquared(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i += 2) // оптимизация по сокращению цикла когда стоял i++
    {
        for (int j = 0; j < matrix.GetLength(1); j += 2)
        {
            //if (i % 2 == 0 && j % 2 == 0) matrix[i, j] *= matrix[i, j];
            matrix[i, j] *= matrix[i, j];
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = CreateRandomMatrix(3, 4, 0, 10);
PrintMatrix(resultMatrix);
Console.WriteLine();
IvenIndexesInSquared(resultMatrix);
PrintMatrix(resultMatrix);