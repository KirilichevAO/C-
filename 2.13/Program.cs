// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(0, 100000);

int ThreeNum (int num)
{
    while (num.ToString().Length > 3)
    {
        num = num / 10;
    }
    return num;
}

if (number.ToString().Length < 3 || number < 0) Console.WriteLine($"{number} -> третьей цифры нет");
else if (number.ToString().Length > 3) Console.WriteLine($"{number} -> {ThreeNum(number) % 10}");
else Console.WriteLine(number % 10);