int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumIntervalNumbers(int M, int N)
{
    if (M > N)
    {
        return 0;
    }
    return M + SumIntervalNumbers(M + 1, N);
}

int M = Prompt("Введите число M: ");
int N = Prompt("Введите число N: ");
Console.Write(SumIntervalNumbers(M, N));
