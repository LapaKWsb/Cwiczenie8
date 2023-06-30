using System;

enum DniTygodnia
{
    Poniedzialek,
    Wtorek,
    Sroda,
    Czwartek,
    Piatek,
    Sobota,
    Niedziela
}

enum EtapyPrania
{
    WstepnePlukanie,
    Pranie,
    Plukanie,
    Odwirowanie,
    Suszenie
}

enum Posilki
{
    Sniadanie = 1,
    DrugieSniadanie,
    Obiad,
    Podwieczorek,
    Kolacja
}

enum BierkiSzachowe
{
    Krol,
    Hetman,
    Goniec,
    Skoczek,
    Wieza,
    Pionek
}

class Program
{
    static void Main(string[] args)
    {
        DniTygodnia dzien = DniTygodnia.Poniedzialek;
        EtapyPrania etap = EtapyPrania.Pranie;
        Posilki posilek = Posilki.Obiad;
        BierkiSzachowe bierka = BierkiSzachowe.Skoczek;

        Console.WriteLine($"Dzień tygodnia: {dzien}");
        Console.WriteLine($"Etap prania: {etap}");
        Console.WriteLine($"Posiłek: {posilek}");
        Console.WriteLine($"Bierka szachowa: {bierka}");

        Console.ReadLine();
    }
}
