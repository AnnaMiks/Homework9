// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

static int Sum(int M, int N)
{
    if (N > M)
    {
        return N + Sum(M, N - 1);

    }

    if (N < M)
    {
        return M + Sum(N, M - 1);

    }

    return N;

}
System.Console.WriteLine(Sum(1, 15));
