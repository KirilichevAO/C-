// Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void ReverseArrayFor(int[] array) // через for
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int odj = array[i];
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = odj;
    }
}

void ReverseArrayWhile(int[] array) // через while
{
    int up = 0;
    int down = array.Length - 1;

    while (up < down)
    {
        int odj = array[up];
        array[up] = array[down];
        array[down] = odj;

        up++;
        down--;
    }
}

int[] array = CreateRandomArray(size: 6, min: 1, max: 10);
PrintArray(array);
Console.WriteLine();
ReverseArrayFor(array);
PrintArray(array);
Console.WriteLine();
ReverseArrayWhile(array);
PrintArray(array);