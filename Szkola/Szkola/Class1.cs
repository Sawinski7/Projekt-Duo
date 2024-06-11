namespace Szkola
{
    public class Uczen
    {
        public string imie;
        public string nazwisko;
        public string klasa;
        public int numerWDzienniku;

        public Uczen(string imie, string nazwisko, string klasa, int numerWDzienniku)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.klasa = klasa;
            this.numerWDzienniku = numerWDzienniku;
        }
    }

    public class Nauczyciel
    {
        public string imie;
        public string nazwisko;
        public string przedmiot;

        public Nauczyciel(string imie, string nazwisko, string przedmiot)
        {
            this.imie = imie;
            this.nazwisko = nazwisko;
            this.przedmiot = przedmiot;
        }
    }

    public class Dyrekcja : Nauczyciel
    {
        public string stanowisko;

        public Dyrekcja(string imie, string nazwisko, string przedmiot, string stanowisko):base(imie, nazwisko, przedmiot)
        {
            this.stanowisko = stanowisko;
        }
    }
}
