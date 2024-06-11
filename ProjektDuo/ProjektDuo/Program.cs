using Szkola;
namespace ProjektDuo
{
    internal class Program
    {
        public static List<Uczen>listaUczniow = new List<Uczen>();
        public static List<Nauczyciel>listaNauczycieli = new List<Nauczyciel>();
        public static List<Dyrekcja>listaCzlonkowDyrekcji = new List<Dyrekcja>();
        static void Main(string[] args)
        {
            int wybor;

            do
            {
                Console.WriteLine("Spis szkoły podstawowej");
                Console.WriteLine("1. Dodaj ucznia");
                Console.WriteLine("2. Dodaj nauczyciela");
                Console.WriteLine("3. Dodaj członka dyrekcji");
                Console.WriteLine("4. Wyświetl wszystkich uczniów");
                Console.WriteLine("5. Wyświetl wszystkich nauczycieli");
                Console.WriteLine("6. Wyświetl wszystkich członków dyrekcji");
                Console.WriteLine("7. Zapisz całość do pliku");
                Console.WriteLine("8. Odczytaj całość z pliku");
                Console.WriteLine("9. Zakończ");
                wybor = Convert.ToInt32(Console.ReadLine());

                if (wybor == 1)
                {
                    DodajUcznia();
                }
                else if (wybor == 2)
                {
                    DodajNauczyciela();
                }
                else if (wybor == 3)
                {
                    DodajDyr();
                }
                else if (wybor == 4)
                {
                    WyswietlUczniow();
                }
                else if (wybor == 5)
                {
                    WyswietlNauczycieli();
                }
                else if (wybor == 6)
                {
                    WyswietlDyr();
                }
                else if (wybor == 7)
                {
                    Zapis();
                }
                else if (wybor == 8)
                {
                    Odczyt();
                }
            }
            while (wybor != 9);
        }

        static void DodajUcznia()
        {
            Console.Clear();
            Console.Write("Podaj imię ucznia: ");
            string i = Console.ReadLine();
            Console.Write("Podaj nazwisko ucznia: ");
            string n = Console.ReadLine();
            Console.Write("Podaj klasę ucznia: ");
            string k = Console.ReadLine();
            Console.Write("Podaj numer w dzienniku: ");
            try
            {
                int nwd = Convert.ToInt32(Console.ReadLine());
                Uczen nowyUczen = new Uczen(i, n, k, nwd);
                listaUczniow.Add(nowyUczen);
                Console.Clear();
                Console.WriteLine("Dodano ucznia\n");
            }
            catch (Exception ex)
            {
                Console.Clear();
                Console.WriteLine($"Wystąpił błąd podczas dodawania ucznia: {ex.Message}\n");
            }
        }

        static void DodajNauczyciela()
        {
            Console.Clear();
            Console.Write("Podaj imię nauczyciela: ");
            string i = Console.ReadLine();
            Console.Write("Podaj nazwisko nauczyciela: ");
            string n = Console.ReadLine();
            Console.Write("Podaj nauczany przedmiot: ");
            string p = Console.ReadLine();

            Nauczyciel nowyNauczyciel = new Nauczyciel(i, n, p);
            listaNauczycieli.Add(nowyNauczyciel);
            Console.Clear();
            Console.WriteLine("Dodano nauczyciela\n");
        }

        static void DodajDyr()
        {
            Console.Clear();
            Console.Write("Podaj imię członka dyrekcji: ");
            string i = Console.ReadLine();
            Console.Write("Podaj nazwisko członka dyrekcji: ");
            string n = Console.ReadLine();
            Console.Write("Podaj nauczany przedmiot: ");
            string p = Console.ReadLine();
            Console.Write("Podaj stanowisko członka dyrekcji: ");
            string s = Console.ReadLine();


            Dyrekcja nowyCzlonekDyr = new Dyrekcja(i, n, p, s);
            listaCzlonkowDyrekcji.Add(nowyCzlonekDyr);
            Console.Clear();
            Console.WriteLine("Dodano członka dyrekcji\n");
        }

        static void WyswietlUczniow()
        {
            Console.Clear();
            Console.WriteLine("Poniżej wyświetlam listę wszystkich uczniów:");
            foreach (var uczen in listaUczniow)
            {
                Console.WriteLine($"Imię ucznia: {uczen.imie}");
                Console.WriteLine($"Nazwisko ucznia: {uczen.nazwisko}");
                Console.WriteLine($"Klasa do której chodzi uczeń: {uczen.klasa}");
                Console.WriteLine($"Numer w dzienniku: {uczen.numerWDzienniku}\n");
            }
        }

        static void WyswietlNauczycieli()
        {
            Console.Clear();
            Console.WriteLine("Poniżej wyświetlam listę wszystkich nauczycieli:");
            foreach (var nauczyciel in listaNauczycieli)
            {
                Console.WriteLine($"Imię nauczyciela: {nauczyciel.imie}");
                Console.WriteLine($"Nazwisko nauczyciela: {nauczyciel.nazwisko}");
                Console.WriteLine($"Nauczany przedmiot: {nauczyciel.przedmiot}\n");
            }
        }

        static void WyswietlDyr()
        {
            Console.Clear();
            Console.WriteLine("Poniżej wyświetlam listę wszystkich członków dyrekcji:");
            foreach (var dyr in listaCzlonkowDyrekcji)
            {
                Console.WriteLine($"Imię członka dyrekcji: {dyr.imie}");
                Console.WriteLine($"Nazwisko członka dyrekcji: {dyr.nazwisko}");
                Console.WriteLine($"Nauczany przedmiot: {dyr.przedmiot}");
                Console.WriteLine($"Obejmowane stanowisko: {dyr.stanowisko}\n");
            }
        }

        static void Zapis()
        {
            Console.Clear();
            StreamWriter sw = new StreamWriter("uczniowie.txt", true);
            foreach (var uczen in listaUczniow)
            {
                sw.WriteLine($"Imię ucznia: {uczen.imie}");
                sw.WriteLine($"Nazwisko ucznia: {uczen.nazwisko}");
                sw.WriteLine($"Klasa do której chodzi uczeń: {uczen.klasa}");
                sw.WriteLine($"Numer w dzienniku: {uczen.numerWDzienniku}\n");
            }
            sw.Close();
            StreamWriter sw2 = new StreamWriter("nauczyciele.txt", true);
            foreach (var nauczyciel in listaNauczycieli)
            {
                sw2.WriteLine($"Imię nauczyciela: {nauczyciel.imie}");
                sw2.WriteLine($"Nazwisko nauczyciela: {nauczyciel.nazwisko}");
                sw2.WriteLine($"Nauczany przedmiot: {nauczyciel.przedmiot}\n");
            }
            sw2.Close();
            StreamWriter sw3 = new StreamWriter("dyr.txt", true);
            foreach (var dyr in listaCzlonkowDyrekcji)
            {
                sw3.WriteLine($"Imię członka dyrekcji: {dyr.imie}");
                sw3.WriteLine($"Nazwisko członka dyrekcji: {dyr.nazwisko}");
                sw3.WriteLine($"Nauczany przedmiot: {dyr.przedmiot}");
                sw3.WriteLine($"Obejmowane stanowisko: {dyr.stanowisko}\n");
            }
            sw3.Close();
            Console.WriteLine("Zapisano całość do pliku");
        }

        static void Odczyt()
        {
            try
            {
                Console.Clear();
                using StreamReader reader = new("uczniowie.txt");
                string text = reader.ReadToEnd();
                Console.WriteLine(text);
                using StreamReader reader2 = new("nauczyciele.txt");
                string text2 = reader2.ReadToEnd();
                Console.WriteLine(text2);
                using StreamReader reader3 = new("dyr.txt");
                string text3 = reader3.ReadToEnd();
                Console.WriteLine(text3);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
