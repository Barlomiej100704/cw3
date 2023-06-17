using System;

class Program
{
    static void Main()
    {
        int n, k;

        do
        {
            Console.Write("Podaj wartość n (większą lub równą 5): ");
            n = int.Parse(Console.ReadLine());
        } while (n < 5);

        do
        {
            Console.Write("Podaj wartość k (większą lub równą 5): ");
            k = int.Parse(Console.ReadLine());
        } while (k < 5);

        int nOblicz = Oblicz(n);
        int kOblicz = Oblicz(k);

        int m = (nOblicz - kOblicz) / kOblicz;

        Console.WriteLine("Wynik: " + m);
        Console.ReadLine();
    }

    static int Oblicz(int numer)
    {
        int zmienna = 1;
        for (int i = 2; i <= numer; i++)
        {
            zmienna *= i;
        }
        return zmienna;
    }
}
