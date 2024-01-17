// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

Console.Write("Введите номер четверти: ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Quarters(int num)
{
    if (num == 1) return "X > 0 и Y > 0";
    if (num == 2) return "X < 0 и Y > 0"; // else не нужен так как return прерывает дальнейшую проверку
    if (num == 3) return "X < 0 и Y < 0"; // else не нужен так как return прерывает дальнейшую проверку
    if (num == 4) return "X > 0 и Y < 0"; // else не нужен так как return прерывает дальнейшую проверку
    return "Введен некорректный номер четверти!"; // else не нужен так как return прерывает дальнейшую проверку

}

Console.Write(Quarters(quarter));