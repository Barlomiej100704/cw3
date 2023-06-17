using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę wyrazów ciągu do wygenerowania: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            int fib = Fibonacci(i);
            Console.WriteLine(fib);
        }
        Console.ReadLine();
    }

    static int Fibonacci(int n)
    {
        if (n <= 1)
        {
            return n;
        }
        else
        {
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}
