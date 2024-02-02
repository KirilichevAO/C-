// Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn = m+n.
// Выведите полученный массив на экран.

int[,] CreateMartixSumInex(int lines, int columns)
{
    int[,] matrix = new int[lines, columns];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = i + j;
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
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

int[,] resultMatrix = CreateMartixSumInex(5, 5, 0, 10);
PrintMatrix(resultMatrix);