namespace ConsoleApp1.Kontenery;

public class KontenerCold : Kontener
{
    protected string RodzajProduktu { get; set; }
    protected double Temperature { get; set; }
    public KontenerCold(double masaMax, double height, double glenbokosc, double selfWeight, string rodzajProduktu, double temperature) : base(masaMax, height, glenbokosc, selfWeight)
    {
        RodzajProduktu = rodzajProduktu;
        Temperature = temperature;
    }

    public override void Oproznenie(double weight)
    {
        if (Weight - weight >=0)
            Weight -= weight;
        else
            Console.WriteLine("Error: weight < 0");
    }

    public override void Zaladowac(double weight)
    {
        if (Weight + weight < MasaMax)
        {
            Weight += weight;
        }
        else
        {
            Console.Write("Too Heavy");
        }
    }
}