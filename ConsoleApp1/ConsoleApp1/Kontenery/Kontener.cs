using ConsoleApp1;

public abstract class Kontener
{
    protected double masaMax;
    public double MasaMax
    {
        get
        {
            return masaMax;
        }
        set { masaMax = value; }
    }

    protected double weight;
    public double Weight    
    {
        get
        {
            return weight;
        }
        set { weight = value; }
    }

    protected static int num { get; set; } = 0;
    protected double height;
    public double Height
    {
        get
        {
            return height;
        }
        set { height = value; }
    }

    protected double Glenbokosc { get; set; }

    public string NumerSeryjny { get; set; }
    protected double selfWeight;
    public double SelfWeight
    {
        get
        {
            return selfWeight;
        }
        set { selfWeight = value; }
    }
    
    protected Kontener(double masaMax, double height, double glenbokosc, double selfWeight)
    {
        MasaMax = masaMax;
        Height = height;
        Glenbokosc = glenbokosc;
        SelfWeight = selfWeight;
    }

    public abstract void Oproznenie(double weight);
    public abstract void Zaladowac(double weight, string rodzajproduktu);


    public abstract void Zaladowac(double weight);
    public abstract void ShowInfo();


}