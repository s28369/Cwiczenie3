using System.Numerics;

namespace ConsoleApp1;

public class Kontenerowec
{
    protected Vector<Kontener> Kontenery { get; set; }
    protected double MaxSpeed { get; set; }
    protected int MaxAmountKonteners { get; set; }
    protected double MaxWeightOfKonteners { get; set; }

    public Kontenerowec(Vector<Kontener> kontenery, double maxSpeed, int maxAmountKonteners, double maxWeightOfKonteners)
    {
        Kontenery = kontenery;
        MaxSpeed = maxSpeed;
        MaxAmountKonteners = maxAmountKonteners;
        MaxWeightOfKonteners = maxWeightOfKonteners;
    }
    
    
}