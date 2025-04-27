using System;

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
