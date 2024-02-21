// Задайте двумерный массив из целых чисел. Напишите программу, которая удалит строку и столбец,
// на пересечении которых расположен наименьший элемент массива.

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

int[,] DellLineColumn(int[,] matrix)
{   
    int[,] resultMatrix = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    
    int line = 0;
    int column = 0;
    int tmp = matrix[0, 0];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (tmp > matrix[i, j])
            {
                tmp = matrix[i, j];
                line = i;
                column = j;
            }
        }
    }
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i == line || j == column)
                continue;
            int newLine = i < line ? i : i - 1;
            int newColumn = j < column ? j : j - 1;

            resultMatrix[newLine, newColumn] = matrix[i, j];
        }
    }

    return resultMatrix;
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
    Console.WriteLine();
}

int[,] randomMatrix = CreateRandomMatrix(5, 5, 0, 10);
PrintMatrix(randomMatrix);
int[,] result = DellLineColumn(randomMatrix);
PrintMatrix(result);