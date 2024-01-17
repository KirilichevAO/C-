// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты точек!");
Console.Write("A(?;y)");
int ax = Convert.ToInt32(Console.ReadLine());
Console.Write("A(x;?)");
int ay = Convert.ToInt32(Console.ReadLine());
Console.Write("B(?;y)");
int bx = Convert.ToInt32(Console.ReadLine());
Console.Write("B(x;?)");
int by = Convert.ToInt32(Console.ReadLine());

double Distance(int num1, int num2, int num3, int num4)
{
    return Math.Sqrt((num3 - num1) * (num3 - num1) + (num4 - num2) * (num4 - num2));
}

Console.Write($"A ({ax}, {ay}); B ({bx}, {by}) -> {Math.Round(Distance(ax, ay, bx, by), 2, MidpointRounding.ToZero)}");