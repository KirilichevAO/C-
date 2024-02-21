// Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных.

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

int[] CreateMatrixToArray(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0) * matrix.GetLength(1)];
    int count = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            array[count] = matrix[i, j];
            count++;
        }
    }
    return array;
}

void FrequencyDictionaryOne(int[] array)
{   
    int count = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < array.Length; j++)
        {
            if (array[i] == array[j]) count++;
        }
        Console.Write($"{array[i]} -> {count} ");
        Console.WriteLine();
        count = 0;
    }
}

void FrequencyDictionaryTwo(int[] array) // второй вариант реализации (не мой)
{   
    int tmp = array[0];
    int count = 1;
    
    for (int i = 1; i < array.Length; i++)
    {
        if (tmp == array[i])
        {
            count++;
        }
        else
        {
            Console.WriteLine($"{tmp} -> {count}");
            tmp = array[i];
            count = 1;
        }
    }
    Console.WriteLine($"{tmp} -> {count}");
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

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[,] randomMatrix = CreateRandomMatrix(3, 3, 0, 10);
PrintMatrix(randomMatrix);
int[] randomArray = CreateMatrixToArray(randomMatrix);
PrintArray(randomArray);
Array.Sort(randomArray);
PrintArray(randomArray);
FrequencyDictionaryTwo(randomArray);

