// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateRandomArray (int size, int min, int max)
{
    double[] array = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.NextDouble() * (max - min) + min;
    }
    return array;
}

void PrintArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        {
            Console.Write($"{array[i]} ");
        }
    }
}

double DifferenceNumbers (double[] array)
{
    double minNumber = array[0];
    double maxNumber = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minNumber) minNumber = array[i];
        else maxNumber = array[i];
    }
    return maxNumber - minNumber;
}

Console.Write("Введите длинну массива: ");
int sizeArray = Convert.ToInt32(Console.ReadLine());

double[] randomArray = CreateRandomArray(sizeArray, 0, 1);

PrintArray(randomArray);

Console.WriteLine($"-> {DifferenceNumbers(randomArray)}");