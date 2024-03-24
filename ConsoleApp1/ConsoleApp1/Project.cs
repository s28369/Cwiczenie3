using System.Security.AccessControl;
using System.Threading.Channels;
using ConsoleApp1.Kontenery;

namespace ConsoleApp1;

public class Project
{
    public static Dictionary<string, double> ProduktyCold = new Dictionary<string, double>();
    public static void Main(string[] args)
    {
        string FilePath = "/Users/alexeymalich/Desktop/APBD/Cwiczenie3/ConsoleApp1/ConsoleApp1/InfoCold.txt";
        ReadColdData(FilePath);
        KontenerPlyn Kont = new KontenerPlyn(1000000, 100, 100, 10, "hazard");
        Kont.Zaladowac(400000);
        Console.WriteLine(Kont.Weight);
        KontenerPlyn Kont1 = new KontenerPlyn(700000, 100, 100, 10, "normal");
        Kont1.Zaladowac(600000);
        KontenerGaz KontG = new KontenerGaz(150, 150, 150, 50, 20);
        KontG.Zaladowac(100);
        Console.WriteLine("Cool");
        KontenerCold KontC = new KontenerCold(100, 100, 100, 10, 10);
        KontC.Zaladowac(100,"bananas");
        Kontenerowec Drive = new Kontenerowec(100, 100, 1000);
        Console.WriteLine(Drive.MaxSpeed);
        Drive.Zaladuj(Kont);
        Drive.Zaladuj(KontG);
        Drive.Zaladuj(KontC);
        Console.WriteLine(Drive.GetWeight());
        List<Kontener> konteners = new List<Kontener>();
        konteners.Add(Kont1);
        konteners.Add(Kont);
        Drive.Zaladuj(konteners);
        Console.WriteLine(Drive.GetWeight());
        Drive.GetKonteners();
        Console.WriteLine("--------------");
        Drive.RemoveKontener(1);
        Console.WriteLine("--------------");
        Drive.ChangeKontener(1,KontG);
        Console.WriteLine("--------------");
        Kontenerowec Drive1 = new Kontenerowec(100, 100, 1000);
        KontenerPlyn KontP = new KontenerPlyn(700000, 100, 100, 10, "normal");
        KontP.Zaladowac(600000);
        Drive1.Zaladuj(KontP);
        Console.WriteLine(Drive1.GetWeight());
        Drive.TransferKontener(1,Drive1);
        Drive1.GetKonteners();
        Drive1.getInfo();



    }

    public static void ReadColdData(string FilePath)
    {
        try
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] Parts = line.Split(" ");
                    ProduktyCold.Add(Parts[0], double.Parse(Parts[1]));
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}