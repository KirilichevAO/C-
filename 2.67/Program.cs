// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12 45 -> 9

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int num)
{
    if (num < 10) return num;
    return num % 10 + SumNumbers(num / 10);
}

int sum = SumNumbers(number);
Console.Write(sum);