﻿// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.
// Например, [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateArrayAndRandom (int size, int min, int max)
{
    int[] array = new int[size];
    Random rnd = new Random();
    
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(min, max + 1);
    }
    return array;
}

int[] PozSumNegSum (int[] array)
{
    int pos = 0;
    int neg = 0;
    
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) pos += array[i];
        else neg += array[i];
    }
    return new int[]{pos, neg};
}

void PrintArray (int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]},");
        else Console.Write(array[i]);
    }
    Console.WriteLine("]");
}

int[] arr = CreateArrayAndRandom(12, -9, 9);
PrintArray(arr);
int[] arrayPozNeg = PozSumNegSum(arr);
Console.WriteLine($"Сумма положительных элементов = {arrayPozNeg[0]}");
Console.WriteLine($"Сумма отрицательных элементов = {arrayPozNeg[1]}");