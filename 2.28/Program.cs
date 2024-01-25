// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int CompositionNumbers (int num)
{
    int composition = 1;

    for (int i = 1; i <= num; i++)
    {
        composition = composition * i;
    }
    return composition;
}

int result = CompositionNumbers(number);
Console.WriteLine($"{number} -> {result}");