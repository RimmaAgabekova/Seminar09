// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.WriteLine("Введите число M");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число N");
int n = Convert.ToInt32(Console.ReadLine());

PrintSumFromMToN(m, n);

int SumFromMToN(int m, int n)
{
    int result = m;
    if (m == n)
        return 0;
    else
    {
        m++;
        result = m + SumFromMToN(m, n);
        return result;
    }
}

void PrintSumFromMToN(int m, int n)
{
    Console.Write("-> " + SumFromMToN(m - 1, n));
}
