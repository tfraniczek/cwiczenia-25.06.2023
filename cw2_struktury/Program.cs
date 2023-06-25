using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw2_struktury
{
    struct Student
    {
        public string Imie;
        public string Nazwisko;
        public string Nr_indeksu;
        public string Uczelnia;
        public string Kierunek_studiow;
        public int Rok_studiow;
        public int Rok_urodzenia;
        public bool Czy_skreslony;
    }
    struct Przedmiot
    {
        public string Nazwa_przedmiotu;
        public string Wykladowca;
        public bool Forma_zaliczeniowa; // true jeśli egzamin na ocenę, false jeśli zaliczenie
        public string Rodzaj_zajec; // ćwiczenia/wykład
        public int iloscECTS;
    }

    struct Nauczyciel_akademicki
    {
        public string Tytul_naukowy;
        public string Imie;
        public string Nazwisko;
        public string Katedra;
        public int Staz_pracy;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
