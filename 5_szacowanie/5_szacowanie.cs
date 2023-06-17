using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj wartość x: ");
        double x = double.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę wyrazów szeregu (n): ");
        int n = int.Parse(Console.ReadLine());

        double suma = 0;
        for (int i = 0; i <= n; i++)
        {
            double wyraz = Math.Pow(x, i) / Obliczenia(i);
            suma += wyraz;
        }

        Console.WriteLine("Szacowana wartość funkcji e^x: " + suma);
        Console.ReadLine();
    }

    static double Obliczenia(int numer)
    {
        double oblicz = 1;
        for (int i = 2; i <= numer; i++)
        {
            oblicz *= i;
        }
        return oblicz;
    }
}
