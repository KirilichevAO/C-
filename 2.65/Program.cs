// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//  M = 1; N = 5 -> "1, 2, 3, 4, 5"
//  M = 4; N = 8 -> "4, 6, 7, 8"

Console.Write("Введите число M: ");
int nummberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int nummberN = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int numM, int numN)
{
    if (nummberM < nummberN)
    {
        if (numN == numM - 1) return;
        NaturalNumbers(numM, numN - 1);
        Console.Write($"{numN} ");
    }
    else
    {
        if (numM == numN - 1) return;
        Console.Write($"{numM} ");
        NaturalNumbers(numM - 1, numN);
    }
}

NaturalNumbers(nummberM, nummberN);