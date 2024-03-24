using System.Security.AccessControl;

namespace ConsoleApp1.Kontenery;

public class KontenerCold : Kontener
{
    protected string RodzajProduktu { get; set; } = "";
    protected double Temperature { get; set; }
    protected static Dictionary<string, double> ProduktyCold = Project.ProduktyCold;
    public KontenerCold(double masaMax, double height, double glenbokosc, double selfWeight, double temperature) : base(masaMax, height, glenbokosc, selfWeight)
    {
        
        Temperature = temperature;
        NumerSeryjny = "KON-" + "C-" + num;
        num++;
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

    public override void Zaladowac(double weight, string rodzajproduktu)
    {
        double temperature = ProduktyCold[rodzajproduktu];
        if (temperature >= Temperature && (RodzajProduktu.Equals(rodzajproduktu) || RodzajProduktu.Equals("")) )
        {
            if (Weight + weight <= MasaMax)
            {
                Weight += weight;
                RodzajProduktu = rodzajproduktu;
            }
            else
            {
                Console.Write("Too Heavy " + NumerSeryjny);
            }
        }
        else if (temperature < Temperature)
        {
            Console.WriteLine("Invalid temperature " +  NumerSeryjny);
        }
        else
        {
            Console.WriteLine("Nieprawidłowy produkt " + NumerSeryjny);   
        }

    }

    public void RodzajProdukt(string rodzaj)
    {
        RodzajProduktu = rodzaj;
    }
}