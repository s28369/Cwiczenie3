using System.Security.AccessControl;

namespace ConsoleApp1.Kontenery;

public class KontenerCold : Kontener
{
    protected string RodzajProduktu { get; set; }
    protected double Temperature { get; set; }
    public KontenerCold(double masaMax, double height, double glenbokosc, double selfWeight, string rodzajProduktu, double temperature) : base(masaMax, height, glenbokosc, selfWeight)
    {
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
    { throw new NotImplementedException(); }

    public override void Zaladowac(double weight, double temperature, string rodzajproduktu)
    {
        if (temperature >= Temperature && (RodzajProduktu.Equals(rodzajproduktu) || RodzajProduktu.Equals("")) )
        {
            if (Weight + weight < MasaMax)
            {
                Weight += weight;
                RodzajProduktu = rodzajproduktu;
            }
            else
            {
                Console.Write("Too Heavy");
            }
        }
        else if (temperature < Temperature)
        {
            Console.WriteLine("Invalid temperature");
        }
        else
        {
            Console.WriteLine("Nieprawidłowy produkt");   
        }

    }
}