// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Clear();
Console.Write("Введите длинну массива: ");
int length = Convert.ToInt32(Console.ReadLine());

int[] array = new int[length];

void RandomArray (int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 2);
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