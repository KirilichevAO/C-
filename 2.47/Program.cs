﻿// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите колличество строк: ");
int sizeLines = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите колличество столбцов: ");
int sizeColumns = Convert.ToInt32(Console.ReadLine());

double[,] CreateMatrix(int size1, int size2, int min, int max)
{
    double[,] matrix = new double[size1, size2];

    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.NextDouble() * (max - min) + min;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
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

double[,] matrix = CreateMatrix(sizeLines, sizeColumns, -9, 10);
PrintMatrix(matrix);