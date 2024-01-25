// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях (индексах).
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateRandomArray (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
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

int SummNambers (int[] array)
{
    int summ = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) summ += array[i];
    }
    return summ;
}

Console.Write("Введите длинну массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] randomArray = CreateRandomArray(sizeArray, 1, 100);

PrintArray(randomArray);
Console.WriteLine($"-> {SummNambers(randomArray)}");