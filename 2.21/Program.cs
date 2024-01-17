// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7) -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точек!");
Console.Write("A(?;y;z)");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A(x;?;z)");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("A(x;y;?)");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("B(?;y;z)");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B(x;?;z)");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("B(x;y;?)");
int z2 = Convert.ToInt32(Console.ReadLine());

double Distance(int num1, int num2, int num3, int num4, int num5, int num6)
{
    return Math.Sqrt((num4 - num1) * (num4 - num1) + (num5 - num2) * (num5 - num2) + (num3 - num6) * (num3 - num6));
}

Console.Write($"A ({x1}, {y1}, {z1}); B ({x2}, {y2}, {z2}) -> {Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2, MidpointRounding.ToZero)}");