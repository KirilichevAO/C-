// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

Console.WriteLine("Введите позиции элемента в двумерном массиве!");
Console.Write("Введите номер строки: ");
int positionElementLine = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер столбца: ");
int positionElementColumn = Convert.ToInt32(Console.ReadLine());

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

void SearchNumber(int[,] matrix, int sizeLine, int sizeColumn)
{
    if (sizeLine < matrix.GetLength(0) && sizeColumn < matrix.GetLength(1)) Console.Write(matrix[sizeLine, sizeColumn]);
    else Console.WriteLine($"{positionElementLine}, {positionElementColumn} -> такого элемента в массиве нет!");
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

int[,] matrixRandom = CreateMatrixRandom(5, 5, 0, 10);
PrintMatrix(matrixRandom);
SearchNumber(matrixRandom, positionElementLine, positionElementColumn);