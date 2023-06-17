using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj liczbę: ");
        int numer = int.Parse(Console.ReadLine());

        int odwroconyNumer = OdwroconyNumer(numer);

        Console.WriteLine("Odwrócona liczba: " + odwroconyNumer);
        Console.ReadLine();
    }

    // Metoda do odwracania kolejności cyfr w liczbie
    static int OdwroconyNumer(int numer)
    {
        int odwroconyNumer = 0;

        while (numer != 0)
        {
            int pamiec = numer % 10;
            odwroconyNumer = odwroconyNumer * 10 + pamiec;
            numer /= 10;
        }

        return odwroconyNumer;
    }
}
