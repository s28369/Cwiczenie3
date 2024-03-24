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
        KontenerPlyn Kont = new KontenerPlyn(100, 100, 100, 10, "hazard");
        Kont.Zaladowac(99);
        KontenerPlyn Kont1 = new KontenerPlyn(100, 100, 100, 10, "normal");
        Kont1.Zaladowac(100);
        KontenerGaz KontG = new KontenerGaz(150, 150, 150, 50, 20);
        KontG.Zaladowac(100);
        KontG.Zaladowac(150);
        Console.WriteLine("Cool");
        KontenerCold KontC = new KontenerCold(100, 100, 100, 10, 10);
        KontC.Zaladowac(100,"ice-cream");
        


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