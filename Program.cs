using System;

// Třída Lucistnik
public class Lucistnik
{
    public string Jmeno { get; private set; }
    public int PocetSipu { get; private set; }

    public Lucistnik(string jmeno, int pocetSipu)
    {
        Jmeno = jmeno;
        PocetSipu = pocetSipu;
    }

    public void Vystrel()
    {
        if (PocetSipu > 0)
        {
            PocetSipu--;
            Console.WriteLine($"{Jmeno} vystrelil sip! Zbyva {PocetSipu} sipu.");
        }
        else
        {
            Console.WriteLine($"{Jmeno} nema zadne sipy!");
        }
    }

    public void PridejSipy(int pocet)
    {
        if (pocet > 0)
        {
            PocetSipu += pocet;
            Console.WriteLine($"{Jmeno} pridal {pocet} sipu. Ted ma {PocetSipu} sipu.");
        }
        else
        {
            Console.WriteLine("Nelze pridat zaporny pocet sipu.");
        }
    }

    public void ZobrazStav()
    {
        Console.WriteLine($"\n{Jmeno} ma {PocetSipu} sipu.\n");
    }
}

// Program
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Zadej jmeno lucistnika:");
        string jmeno = Console.ReadLine();

        Lucistnik lucistnik = new Lucistnik(jmeno, 5); // defaultne 5 sipu na zacatek

        bool pokracovat = true;

        while (pokracovat)
        {
            lucistnik.ZobrazStav();
            Console.WriteLine("Vyber akci:");
            Console.WriteLine("1 - Vystrel sip");
            Console.WriteLine("2 - Pridej sipy");
            Console.WriteLine("3 - Konec");

            Console.Write("Tvoje volba: ");
            string volba = Console.ReadLine();

            switch (volba)
            {
                case "1":
                    lucistnik.Vystrel();
                    break;
                case "2":
                    int pocet = NactiCeleCisloZKonzole("Kolik sipu chces pridat?");
                    lucistnik.PridejSipy(pocet);
                    break;
                case "3":
                    Console.WriteLine("Ukoncuji program.");
                    pokracovat = false;
                    break;
                default:
                    Console.WriteLine("Neplatna volba, zkus to znovu.");
                    break;
            }
        }
    }

    public static int NactiCeleCisloZKonzole(string vyzva)
    {
        int cislo;
        while (true)
        {
            Console.WriteLine(vyzva);
            string vstup = Console.ReadLine();

            if (int.TryParse(vstup, out cislo) && cislo >= 0)
            {
                return cislo;
            }
            else
            {
                Console.WriteLine("Neplatny vstup. Zadej kladne cele cislo.");
            }
        }
    }
}
