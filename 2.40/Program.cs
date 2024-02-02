// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

Console.WriteLine("Введите значение трех сторон треугольника!");

Console.Write("Первое значение: ");
int sideOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Второе значение: ");
int sideTwo = Convert.ToInt32(Console.ReadLine());

Console.Write("Третье значение: ");
int sideThree = Convert.ToInt32(Console.ReadLine());

void SummaSideVoid(int num1, int num2, int num3)
{
    if (num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2) Console.Write(("Триугольник существует."));
    else Console.Write("Треугольник не существует");
}

bool SummaSideBool(int num1, int num2, int num3)
{
    return num1 < num2 + num3 && num2 < num1 + num3 && num3 < num1 + num2;
}

SummaSideVoid(sideOne, sideTwo, sideThree);

Console.WriteLine();

bool result = SummaSideBool(sideOne, sideTwo, sideThree);
if (result) Console.Write(("Триугольник существует."));
else Console.Write("Треугольник не существует");