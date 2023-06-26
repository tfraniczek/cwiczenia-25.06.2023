using System;

namespace Ćw_8_zajecia
{
    enum Plec
    {
        Kobieta,
        Mezczyzna,
    }

    struct Student
    {
        public string Nazwisko;
        public int Nr_albumu;
        public int Ocena;
        public string Plec;
        
    }
    class Program
    {
        static void Wypelnij_oceny(ref Student osoba,
        string Nazwisko,
        int Nr_albumu,
        int Ocena,
        string Plec)
        {
            
            if (Ocena > 5.0)
            {
                osoba.Ocena = 5;
            }
            if (Ocena <2.0)
            {
                osoba.Ocena = 2;
            }
            osoba.Nazwisko = Nazwisko;
            osoba.Nr_albumu = Nr_albumu;
            osoba.Ocena = Ocena;
            osoba.Plec = Plec;

        }
        static void Wyswietl(Student studenci)
        {
            Console.WriteLine($"Student: {studenci.Nazwisko} {studenci.Nr_albumu} {studenci.Ocena} {studenci.Plec}");
            Console.WriteLine();
            Console.ReadLine();
        }
        static double LiczSrednia(Student[] studenci)
        {
            int caloscOcen = 0;

            foreach (Student student in studenci)
            {
                caloscOcen += student.Ocena;
            }

            double srednia = (double)caloscOcen / studenci.Length;
            return srednia;
        }



        static void Main(string[] args)
        {
            Student[] studenci = new Student[5];

            Wypelnij_oceny(ref studenci[0], "Kowalski", 10000, 3, "Mezczyzna");
            Wypelnij_oceny(ref studenci[1], "Nowak", 10001, 6, "Kobieta");
            Wypelnij_oceny(ref studenci[2], "Maniak", 10002, 1, "Mezczyzna");
            Wypelnij_oceny(ref studenci[3], "Krakusek", 10003, 4, "Kobieta");
            Wypelnij_oceny(ref studenci[4], "Adamska", 10004, 5, "Kobieta");

            Wyswietl(LiczSrednia);
        }

        
    }
}
