// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] array = new int[8];

void RandomArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

void PrintArray (int[] ar)
{
    for (int j = 0; j < ar.Length; j++)
    {
        Console.Write($"{ar[j]} "); 
    }
}

RandomArray(array);
PrintArray(array);