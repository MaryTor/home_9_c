//Задайте значение N. Напишите программу, которая выведет все натуральные числа 
//в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Clear();
int n = InputInt("Введите положительное число: ");
int m = 1;
if (n < 1)
{
    Console.WriteLine("Ввели не положительное число");
}
Console.WriteLine(PositiveNumber(n, m));

int PositiveNumber(int n, int m)
{
    if (n == m)
        return n;
    else
        Console.Write($"{PositiveNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}