// Напишите программу, которая на вход принимает два числа A и B, и возводит число А в целую степень B с помощью рекурсии.
//  A = 3; B = 5 -> 243 (35) A = 2; B = 3 -> 8

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int KvadroNumbers(int numA, int numB)
{
    if (numB == 0) return 1;
    if (numB == 1) return numA;
    return numA * KvadroNumbers(numA, numB - 1);
}

int kvadro = KvadroNumbers(numberA, numberB);
Console.Write(kvadro);