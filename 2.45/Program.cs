// Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] arrayOld = { 2, 4, 6, 8, 10, 12, 14 };

int[] CopyArray(int[] array)
{
    int[] arrayNow = new int[array.Length];

    for (int i = 0; i < array.Length; i++)
    {
        arrayNow[i] = array[i];
    }
    return arrayNow;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int[] resultArray = CopyArray(arrayOld);

PrintArray(resultArray);