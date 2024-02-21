// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

void MatrixSumLine(int[,] matrix)
{
    int[] arraySum = new int[matrix.GetLength(0)];
    int sum = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arraySum[i] = sum;
        sum = 0;
    }

    int sumMin = arraySum[0];
    int indexNum = 0;

    for (int i = 0; i < arraySum.Length; i++)
    {
        if (sumMin < arraySum[i])
        {
            sumMin = arraySum[i];
            indexNum = i;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: {indexNum + 1} и ее сумма чисел равна: {sumMin}");
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
MatrixSumLine(randomMatrix);