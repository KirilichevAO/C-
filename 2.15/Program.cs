// Напишите программу, которая принимает на вход цифру, обозначающую день недели,
// и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите порядковую цифру дня недели: ");
int numberWeek = Convert.ToInt32(Console.ReadLine());

bool NumWeek(int num)
{
    return num == 6 || num == 7;
}

if (numberWeek < 1 || numberWeek > 7) Console.WriteLine($"{numberWeek} -> не является днем недели");
else Console.WriteLine($"{numberWeek} -> {NumWeek(numberWeek)}");