int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int IntervalNumbers(int N)
{
    Console.WriteLine(N);

    if (N <= 1)
    {
        return 1;
    }
    N--;
    return IntervalNumbers(N);
}

int N = Prompt("Введите число: ");
IntervalNumbers(N);
