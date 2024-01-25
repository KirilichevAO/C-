// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumNum (int num)
{
    int res = 0;
    while (num / 10 > 0 || num % 10 > 0)
    {
        res = res + (num % 10);
        num = num / 10;
    }
    return res;
}

int result = SumNum(number);
Console.WriteLine(result);