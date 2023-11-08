// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44, 5, 78 -> 78
// 22, 3, 9 -> 22

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numThre = Convert.ToInt32(Console.ReadLine());
int numMax = numOne;

if(numMax < numTwo) numMax = numTwo;
if(numMax < numThre) numMax = numThre;
Console.Write($"{numOne}, {numTwo}, {numThre} -> {numMax}");