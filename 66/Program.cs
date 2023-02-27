//Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.Clear();
int m = InputInt("Введите M:");
int n = InputInt("Введите N:");
Console.WriteLine();
Console.WriteLine($"Сумма элементов в промежутке от {m} до {n} = {CountPositiveSum(m, n)}");

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

int CountPositiveSum(int m, int n)
{
    if (m == n)
        return n;
    return n + CountPositiveSum(m, n - 1);
}