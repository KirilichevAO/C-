// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int DecimalInBinary(int num)
{
    int result = 0;
    int i = 1;
    
    while (num > 0)
    {
        result = result + num % 2 * i;
        num = num / 2;
        i = i * 10;
    }
    return result;
}

void DecimalInBinaryRec(int num) // через рекурсию
{
    if (num == 0) return;

    DecimalInBinaryRec(num / 2);

    Console.Write(num % 2);
}


int result = DecimalInBinary(number);
Console.WriteLine(result);

DecimalInBinaryRec(number);