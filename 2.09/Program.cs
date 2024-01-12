// Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

int numRandom = new Random().Next(10, 100);
// int numOne = numRandom / 10; // переносим часть этого кода в функцию
// int numTwo = numRandom % 10;

// if(numOne == numTwo) // изучив тернарный оператор сокращаем код
// {
//     Console.WriteLine($"{numRandom} -> Цифры ровны!");
// }
// else if(numOne > numTwo)
// {
//     Console.WriteLine($"{numRandom} -> {numOne}");
// }
// else
// {
//     Console.WriteLine($"{numRandom} -> {numTwo}");
// }

// int numOneTwo = numOne > numTwo ? numOne : numTwo; // если numOne > numTwo тогда(?) numOne иначе(:) umTwo
// Console.WriteLine($"{numRandom} -> {numOneTwo}");

int NumMax(int num) // функция
{
    int numOne = numRandom / 10;
    int numTwo = numRandom % 10;
    if(numOne == numTwo) return -1; // -1 - возвращаемое значение что цифры равны
    return numOne > numTwo ? numOne : numTwo;
}

// int result = NumMax(numRandom); // вызываем функцию и передаем в нее аргумент
// string res = result == -1 ? "Цифры одинаковые" : result.ToString(); // приобразовываем -1 в текстовую информацию
// Console.WriteLine($"{numRandom} -> {res}");

string result = NumMax(numRandom) == -1 ? "Цифры одинаковые" : NumMax(numRandom).ToString(); // приобразовываем -1 в текстовую информацию
Console.WriteLine($"{numRandom} -> {result}");