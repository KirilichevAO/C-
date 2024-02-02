// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.Write("Введите колличество чисел: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arrayNumbers = new int[size];

for (int i = 0; i < arrayNumbers.Length; i++)
{
    Console.Write("Введите число: ");
    arrayNumbers[i] = Convert.ToInt32(Console.ReadLine());
}

void PozitiveNombers(int[] array)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    Console.WriteLine($"-> {count}");
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

PrintArray(arrayNumbers);
PozitiveNombers(arrayNumbers);