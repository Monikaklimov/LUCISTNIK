using System;

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
