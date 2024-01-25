// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

Console.Clear();

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

int SearchNumbers (int[] array, int min, int max)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i] <= max) count++;
    }
    return count;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

Console.Write("Введите длинну массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите диапазон поиска!");
Console.Write("От: ");
int minRange = Convert.ToInt32(Console.ReadLine());
Console.Write("До: ");
int maxRange = Convert.ToInt32(Console.ReadLine());

int[] arrayRandom = CreateRandomArray(sizeArray, 0, 10);
PrintArray(arrayRandom);
Console.Write($" -> {SearchNumbers(arrayRandom, minRange, maxRange)}");