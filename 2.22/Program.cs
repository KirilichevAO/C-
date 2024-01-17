﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Square (int num)
{
    for (int i = 1; i <= num; i++)
    {   
        Console.WriteLine($"{i} \t {i * i}");
    }
}

if (number < 1)
{
    Console.Write("Введено некорректное значение!");
    return;
}

Square(number);