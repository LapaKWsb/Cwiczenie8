using System;

namespace Zadaneczko
{
    using System;

    struct Student
    {
        public string Imie;
        public string Nazwisko;
        public string Kierunek;
        public int NumerIndeksu;
    }

    struct Przedmiot
    {
        public string Nazwa;
        public string Prowadzacy;
        public int ECTS;
    }

    struct NauczycielAkademicki
    {
        public string Imie;
        public string Nazwisko;
        public string Specjalizacja;
        public string TytulNaukowy;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student;
            student.Imie = "Marcin";
            student.Nazwisko = "Góra";
            student.NumerIndeksu = 667788;
            student.Kierunek = "Pielęgniarstwo";

            Przedmiot przedmiot;
            przedmiot.Nazwa = "Przewijanie Pacjentów";
            przedmiot.ECTS = 15;
            przedmiot.Prowadzacy = "Dr. Piotr Urbańczyk";

            NauczycielAkademicki nauczyciel;
            nauczyciel.Imie = "Piotr";
            nauczyciel.Nazwisko = "Urbańczyk";
            nauczyciel.TytulNaukowy = "dr";
            nauczyciel.Specjalizacja = "Przewijanie Pacjentów";

            Console.WriteLine("Informacje o studencie:");
            Console.WriteLine($"Imię: {student.Imie}");
            Console.WriteLine($"Nazwisko: {student.Nazwisko}");
            Console.WriteLine($"Numer indeksu: {student.NumerIndeksu}");
            Console.WriteLine($"Kierunek: {student.Kierunek}");

            Console.WriteLine();

            Console.WriteLine("Informacje o przedmiocie:");
            Console.WriteLine($"Nazwa: {przedmiot.Nazwa}");
            Console.WriteLine($"ECTS: {przedmiot.ECTS}");
            Console.WriteLine($"Prowadzący: {przedmiot.Prowadzacy}");

            Console.WriteLine();

            Console.WriteLine("Informacje o nauczycielu akademickim:");
            Console.WriteLine($"Imię: {nauczyciel.Imie}");
            Console.WriteLine($"Nazwisko: {nauczyciel.Nazwisko}");
            Console.WriteLine($"Tytuł naukowy: {nauczyciel.TytulNaukowy}");
            Console.WriteLine($"Specjalizacja: {nauczyciel.Specjalizacja}");

            Console.ReadLine();
        }
    }
}
