// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] CreateRandomArray (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

int EvenNumbers (int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count++;
    }
    return count;
}

Console.Write("Введите длинну массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] randomArray = CreateRandomArray(sizeArray, 100, 1000);

PrintArray(randomArray);
Console.WriteLine($"-> {EvenNumbers(randomArray)}");



