// Задайте двумерный массив размером m×n, заполненный случайными целыми числами.

Console.Write("Введите колличество строк: ");
int sizeLines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

int[,] CreateMatrix(int size1, int size2, int min, int max)
{
    int[,] matrix = new int[size1, size2];

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
            Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(sizeLines, sizeColumns, -9, 10);
PrintMatrix(matrix);