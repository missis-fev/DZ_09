// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
//N = 5 -> "5, 4, 3, 2, 1"
//N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);

int outNumber(int N)
{
    if (N == 0)  
    return 0;
    if (N == 1) Console.Write($"{N}");
    else
    {
        Console.Write($"{N}, ");
        outNumber(N - 1);
    }
    return 0;

}
outNumber(N);