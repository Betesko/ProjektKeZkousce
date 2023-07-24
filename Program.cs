using System;
using ProjektKeZkousce;

public class Program
{
    static void Main(string[] args)
    {
        // Vytvoření instance EvidencePojisteni pro správu dat
        EvidencePojisteni evidence = new EvidencePojisteni();

        // Proměnná pro kontrolu ukončení programu
        bool konec = false;
        while (!konec)
        {
            // Výpis nabídky akcí pro uživatele
            Console.WriteLine("===================================================");
            Console.WriteLine("============== Evidence Pojištěných ===============");
            Console.WriteLine("===================================================");
            Console.WriteLine("Vyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec (ukončí program)");

            // Načtení volby uživatele
            string volba = Console.ReadLine();
            Console.WriteLine();

            // Rozhodnutí na základě volby uživatele
            switch (volba)
            {
                case "1":
                    // Přidání nového pojištěného
                    Console.WriteLine("Zadejte křestní jméno pojištěného:");
                    string jmeno = Console.ReadLine();

                    Console.WriteLine("Zadejte příjmení pojištěného:");
                    string prijmeni = Console.ReadLine();

                    Console.WriteLine("Zadejte telefonní číslo (bez předvolby):");
                    string telefonniCislo = Console.ReadLine().Trim();
                    //odstraní mezery v zadaném telefonním čísle
                    telefonniCislo = telefonniCislo.Replace(" ", "");


                    Console.WriteLine("Zadejte věk:");
                    int vek;
                    string vekString = Console.ReadLine();

                    if (int.TryParse(vekString, out vek))
                    {
                        
                        evidence.VytvoritPojisteneho(jmeno, prijmeni, vek, telefonniCislo.Trim());
                        Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
                        Console.ReadKey();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Neplatný věk. Zadejte prosím pouze celé číslo.");
                    }
                    break;

                case "2":
                    // Výpis všech pojištěných
                    Console.WriteLine("Seznam všech pojištěných:");
                    Console.WriteLine(); // Prázdný řádek pro odsazení seznamu
                    evidence.ZobrazitVsechnyPojistene();
                    Console.WriteLine("Pokračujte libovolnou klávesou...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "3":
                    // Vyhledání pojištěného
                    Console.WriteLine("Zadejte jméno pojištěného:");
                    string hledaneJmeno = Console.ReadLine();

                    Console.WriteLine("Zadejte příjmení pojištěného:");
                    string hledanePrijmeni = Console.ReadLine();

                    Pojisteny hledany = evidence.NajitPojisteneho(hledaneJmeno, hledanePrijmeni);
                    if (hledany != null)
                    {
                        Console.WriteLine("Výsledek hledání:");
                        Console.WriteLine(hledany);
                    }
                    else
                    {
                        Console.WriteLine("Pojištěný nebyl nalezen.");
                    }

                    Console.WriteLine("Pokračujte libovolnou klávesou...");
                    Console.ReadKey();
                    Console.Clear();
                    break;

                case "4":
                    // Ukončení programu
                    konec = true;
                    break;

                default:
                    // Neplatná volba
                    Console.WriteLine("Neplatná volba. Zvolte prosím platnou akci.");
                    break;
            }
        }
    }
}
