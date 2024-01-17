// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта точка.

Console.Write("Введите значение X: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение Y: ");
int y = Convert.ToInt32(Console.ReadLine());

string Quarters(int num1, int num2)
{
    if (num1 > 0 && num2 > 0) return $"При координатах X = {num1}; Y = {num2} - 1 четверть.";
    if (num1 < 0 && num2 > 0) return $"При координатах X = {num1}; Y = {num2} - 2 четверть."; // else не нужен так как return прерывает дальнейшую проверку
    if (num1 < 0 && num2 < 0) return$"При координатах X = {num1}; Y = {num2} - 3 четверть."; // else не нужен так как return прерывает дальнейшую проверку
    if (num1 > 0 && num2 < 0) return $"При координатах X = {num1}; Y = {num2} - 4 четверть."; // else не нужен так как return прерывает дальнейшую проверку
    return "Введены некорректные значения координат!"; // else не нужен так как return прерывает дальнейшую проверку

}

Console.Write(Quarters(x, y));