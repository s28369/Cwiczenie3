using System.Security.AccessControl;
using System.Threading.Channels;
using ConsoleApp1.Kontenery;

namespace ConsoleApp1;

public class Project
{
    public static void Main(string[] args)
    {
        KontenerPlyn Kont = new KontenerPlyn(100, 100, 100, 10, "hazard");
        Kont.Zaladowac(99);
        KontenerPlyn Kont1 = new KontenerPlyn(100, 100, 100, 10, "normal");
        Kont1.Zaladowac(100);
        KontenerGaz KontG = new KontenerGaz(150, 150, 150, 50, 20);
        KontG.Zaladowac(100);
        KontG.Zaladowac(150);
        Console.WriteLine("Cool");
        Dictionary<string, double> ProduktyCold = new Dictionary<string, double>();
        

    }
}