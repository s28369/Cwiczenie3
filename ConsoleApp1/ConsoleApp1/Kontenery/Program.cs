using ConsoleApp1;

public abstract class Kontener
{
    protected double MasaMax { get; }
    protected double Weight { get; set; } = 0;
    protected static int num { get; set; } = 0;
    protected double Height { get; set; }

    protected double Glenbokosc { get; set; }

    public String NumerSeryjny { get; set; }
    protected double SelfWeight { get; set; }
    
    protected Kontener(double masaMax, double height, double glenbokosc, double selfWeight)
    {
        MasaMax = masaMax;
        Height = height;
        Glenbokosc = glenbokosc;
        SelfWeight = selfWeight;
    }

    public abstract void Oproznenie();


    public abstract void Zaladowac(double weight);


}