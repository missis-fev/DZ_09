// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных
// элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

Console.WriteLine("Введите начальное число M:");
int numM = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите начальное число N:");
int numN = int.Parse(Console.ReadLine()!);

Sum(numM, numN);

void Sum(int numM, int numN)
{
    Console.Write(SumMN(numM - 1, numN));
}

int SumMN(int numM, int numN)
{
    int rez = numM;
    if (numM == numN)
        return 0;
    else
    {
        numM++;
        rez = numM + SumMN(numM, numN);
        return rez;
    }
}