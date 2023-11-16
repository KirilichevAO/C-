// Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int TowNum(int number)
{
    return number % 100 / 10;
}

if (num.ToString().Length != 3) Console.Write($"Число {num} не трехзначное, попробуйте еще раз!!!");
else Console.Write($"{num} -> {TowNum(num)}");