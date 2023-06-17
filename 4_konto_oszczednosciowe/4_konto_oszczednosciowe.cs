using System;

class Program
{
    static void Main()
    {
        Console.Write("Podaj kwotę początkową: ");
        decimal kwotaPoczatkowa = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj oprocentowanie w skali roku: ");
        decimal oprocentowanie = decimal.Parse(Console.ReadLine());

        Console.Write("Podaj liczbę miesięcy oszczędzania: ");
        int liczbaMiesiecy = int.Parse(Console.ReadLine());

        decimal oprocentowanieMiesieczne = oprocentowanie / 12 / 100;
        decimal kwotaKoncowa = kwotaPoczatkowa * (1 + oprocentowanieMiesieczne) * (decimal)Math.Pow(1 + (double)oprocentowanieMiesieczne, liczbaMiesiecy - 1);

        decimal podatekBelki = 0.19m * (kwotaKoncowa - kwotaPoczatkowa);
        kwotaKoncowa -= podatekBelki;

        Console.WriteLine("Kwota końcowa na koncie oszczędnościowym: " + kwotaKoncowa);
        Console.ReadLine();
    }
}
