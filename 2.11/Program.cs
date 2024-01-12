// Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int numRandom = new Random().Next(100, 1000);

int delNum(int num)
{
    int numOne = num / 100;
    int numTwo = num % 10;
    return numOne * 10 + numTwo;
}

int result = delNum(numRandom);
Console.WriteLine($"{numRandom} -> {result}");