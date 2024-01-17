// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Palindrome (int num)
{
    if (num / 10000 == num % 10 && num / 1000 % 10 == num % 100 / 10)
    {
        Console.Write($"{num} -> да");
    }
    else Console.Write($"{num} -> нет");
}

if (number < 10000 || number > 99999)
{
    Console.Write("Введено некорректное значение!");
    return;
}

Palindrome(number);