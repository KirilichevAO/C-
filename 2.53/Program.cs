// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.

int[,] CreateRandomMatrix(int sizeLine, int sizeColumn, int min, int max)
{
    int[,] matrix = new int[sizeLine, sizeColumn];
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

int[,] Revers(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int number = matrix[0, j];

        matrix[0, j] = matrix[matrix.GetLength(1) -1, j];

        matrix[matrix.GetLength(1) -1, j] = number;
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

int[,] randomMatrix = CreateRandomMatrix(5, 5, 0, 10);
PrintMatrix(randomMatrix);
Console.WriteLine();
int[,] reversMatrix = Revers(randomMatrix);
PrintMatrix(reversMatrix);