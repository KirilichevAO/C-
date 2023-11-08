// Напишите программу, которая на вход принимает два числа и проверяет,
// является ли первое число квадратом второго.
// a = 25, b = 5 -> да
// a = 2, b = 10 -> нет
// a = 9, b = -3 -> да
// a = -3 b = 9 -> нет

Console.Write("Введите число a: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int numTow = Convert.ToInt32(Console.ReadLine());


if (numTow * numTow == numOne)
{
    Console.Write($"a = {numOne}, b = {numTow} -> да");
}
else
{
    Console.Write($"a = {numOne}, b = {numTow} ->Нет");
}
