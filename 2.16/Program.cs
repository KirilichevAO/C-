// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

int Kvadrat(int num1, int num2)
{
    return num1 * num1 == num2 || num2 * num2 == num1 ? 1 : 0;
}

int result = Kvadrat(numOne, numTwo);
string res = result == 1 ? "yes" : "no";
Console.Write($"{numOne}, {numTwo} -> {res}");