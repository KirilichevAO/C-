// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int Nnumbers (int num)
{
    int count = 0;

    if (num == 0) return 1;

    while (num > 0)
    {
        num = num / 10;
        count++;
    }
    return count;
}

Console.Write($"{number} -> {Nnumbers(number)}");