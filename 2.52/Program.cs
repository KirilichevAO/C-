// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] CreateMatrixRandom(int sizeLine, int sizeColumn, int min, int max)
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

void PrintArray(double[] array, int size)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i] / size}; ");
    }
}

double[] ArithmeticMeanColumns(int[,] matrix)
{
    int size = matrix.GetLength(1);

    double[] array = new double[size];

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
           array[i] += matrix[j, i];
        }
    }
    return array;
}

int[,] matrixRandom = CreateMatrixRandom(5, 5, 0, 3);
PrintMatrix(matrixRandom);
double[] arrayResult = ArithmeticMeanColumns(matrixRandom);
PrintArray(arrayResult, 5);