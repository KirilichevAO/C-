// Лекция 4 - Двумерные массивы и рекурсия.

// string[,] table = new string[2, 5];

// table[1, 2] = "Слово";

// for (int rows = 0; rows < 2; rows++)
// {
//     for (int columns = 0; columns < 5; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// }

void Matrix(int[,] matri)
{
    for (int i = 0; i < matri.GetLength(0); i++) // GetLength(0) выдаст количество строк - 3
    {
        for (int j = 0; j < matri.GetLength(1); j++) // GetLength(1) выдаст количество столбцов - 4
        {
            Console.Write($"{matri[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matri)
{
    for (int i = 0; i < matri.GetLength(0); i++)
    {
        for (int j = 0; j < matri.GetLength(1); j++)
        {
            matri[i,j] = new Random().Next(1,10);
        }
    }
}

int[,] matrix = new int[3, 4];

Matrix(matrix);
FillArray(matrix);
Console.WriteLine();
Matrix(matrix);