namespace ConsoleApp1.Kontenery;

public class KontenerGaz : Kontener, IHazardNotifier
{
    protected double Pressure { get; set; }

    public KontenerGaz(double masaMax, double height, double glenbokosc, double selfWeight , double pressure) : base(masaMax, height, glenbokosc, selfWeight)
    {
        Pressure = pressure;
        NumerSeryjny = "KON-" + "G-" + num;
        num++;
    }

    public override void Oproznenie(double weight)
    {
        if (Weight - weight < Weight * 0.05)
            HazardAlert(NumerSeryjny);
            

    }

    public override void Zaladowac(double weight, string rodzajproduktu)
    {
        throw new NotImplementedException();
    }


    public override void Zaladowac(double weight)
    {
        double WeightNow = Weight;
        WeightNow += weight;
        try
        {
            if (WeightNow > MasaMax)
                throw new OverfillException();
            else
                Weight = WeightNow;
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e + " in " + NumerSeryjny);
        }
    }

    public override void ShowInfo()
    {
        Console.WriteLine(NumerSeryjny + " " + Pressure + " " + Weight);
    }

    public void HazardAlert(string cont)
    {
        Console.WriteLine("WARNING IN " + cont);
    }
}