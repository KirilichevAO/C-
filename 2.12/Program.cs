// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
// кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.Write("Введите первое число: ");
int numOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numTwo = Convert.ToInt32(Console.ReadLine());

// if(numOne % numTwo == 0) // перенесли это ветвление в метод Krat
// {
//     Console.Write($"{numOne}, {numTwo} -> кратно");
// }
// else
// {
//     Console.Write($"{numOne}, {numTwo} -> не кратно {numOne % numTwo}");
// }

int Krat(int num1, int num2)
{
    return num1 % num2 == 0 ? -1 : num1 % num2;
}

string result = Krat(numOne, numTwo) == -1 ? "кратно" : $"не кратно, остаток {Krat(numOne, numTwo).ToString()}";
Console.Write($"{numOne}, {numTwo} -> {result}");

