// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

// Console.Write("Введите число: "); // один вариант решения
// int num = Convert.ToInt32(Console.ReadLine());

// int Krat(int number)
// {
//     return number % 7 == 0 && number % 23 == 0 ? 1 : 0;
// }

// int result = Krat(num);
// string res = result == 1 ? "yes" : "no";
// Console.Write($"{num} -> {res}");

Console.Write("Введите число: "); // другой вариант решения
int num = Convert.ToInt32(Console.ReadLine());

bool Krat(int number, int a, int b)
{
    return number % a == 0 && number % b == 0;
}

if (Krat(num, 7, 23)) Console.Write($"{num} -> yes");
else Console.Write($"{num} -> no");