using System.Security.AccessControl;
using System.Threading.Channels;
using ConsoleApp1.Kontenery;

namespace ConsoleApp1;

public class Project
{
    public static void Main(string[] args)
    {
        KontenerPlyn kont = new KontenerPlyn(100, 100, 100, 10, "hazard");
        kont.Zaladowac(99);
        KontenerPlyn kont1 = new KontenerPlyn(100, 100, 100, 10, "normal");
        kont1.Zaladowac(100);
        
    }
}