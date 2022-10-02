int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int AkkermanFunction(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m != 0) && (n == 0))
      return AkkermanFunction(m - 1, 1);
    else
      return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1));
}

int m = Prompt("Введите значение m: ");
int n = Prompt("Введите значение n: ");
Console.Write(AkkermanFunction(m, n));
