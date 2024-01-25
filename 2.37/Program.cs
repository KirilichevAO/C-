// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

Console.Clear();

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

int[] NumberSumm (int[] array) // метод реализованный через while
{
    int size = array.Length % 2 == 0 ? array.Length / 2 : array.Length / 2 + 1;
    int[] result = new int[size];
    int firstIndex = 0;
    int lastIndex = array.Length - 1;

    while (lastIndex > firstIndex)
    {
        result[firstIndex] = array[firstIndex] * array[lastIndex];
        firstIndex++;
        lastIndex--;
    }

    if (lastIndex == firstIndex) result[size - 1] = array[lastIndex];

    return result;
}

int[] NumberSummTwo (int[] array) // метод реализованный через for
{
    int size = array.Length / 2;
    if (array.Length % 2 != 0) size++;
    int[] result = new int[size];

    for (int i = 0; i < array.Length / 2; i++)
    {
        result[i] = array[i] * array[array.Length - i - 1];
    }

    if (array.Length % 2 != 0) result[size - 1] = array[array.Length / 2];

    return result;
}

Console.Write("Введите длинну массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

int[] arrayRandom = CreateRandomArray(sizeArray, 0, 10);

PrintArray(arrayRandom);

Console.Write("-> ");

int[] arrayResult = NumberSummTwo(arrayRandom);

PrintArray(arrayResult);

