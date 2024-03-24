namespace ConsoleApp1.Kontenery;

public class KontenerPlyn : Kontener, IHazardNotifier
{
    protected string TypLadunku;
    public KontenerPlyn(double masaMax, double height, double glenbokosc, double selfWeight, string typLadunku) : base(masaMax, height, glenbokosc, selfWeight)
    {
        TypLadunku = typLadunku;
        NumerSeryjny = "KON-" + "C-" + num;
        num++;
    }


    public override void Zaladowac(double weight, double temperature, string rodzajproduktu)
    { throw new NotImplementedException(); }

    public override void Zaladowac(double weight)
    {
        double WeightNow = Weight;
        try
        {
            WeightNow += weight;
            if ((WeightNow > MasaMax / 2) && TypLadunku.Equals("hazard") || (WeightNow > MasaMax*0.9) && TypLadunku.Equals("normal"))
            {
                HazardAlert(NumerSeryjny);
                WeightNow -= weight;
            }
            else
            {
                if (WeightNow > MasaMax)
                    throw new OverfillException("Overfill");
                Weight = WeightNow;
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e);
        }
    }
    
    public override void Oproznenie(double weight)
    {
        if (Weight - weight >=0)
            Weight -= weight;
        else
            Console.WriteLine("Error: weight < 0");
    }


    public void HazardAlert(string kont)
    {
        Console.WriteLine("WARNING IN " + kont);
        
    }
}