using System.Numerics;
using System.Security.AccessControl;
using ConsoleApp1.Kontenery;

namespace ConsoleApp1;

public class Kontenerowec
{
    protected List<Kontener> Kontenery { get; set; } = new List<Kontener>();
    protected double maxSpeed;
    public double MaxSpeed
    {
        get
        {
            return maxSpeed;
        }
        set { maxSpeed = value; }
    }
    public int MaxAmountKonteners { get; set; }
    public double MaxWeightOfKonteners { get; set; }

    public Kontenerowec(double maxSpeed, int maxAmountKonteners, double maxWeightOfKonteners)
    {
        this.maxSpeed = maxSpeed;
        MaxAmountKonteners = maxAmountKonteners;
        MaxWeightOfKonteners = maxWeightOfKonteners;
    }

    public void Zaladuj(Kontener kontener)
    {
        try
        {

            if (kontener.Weight/1000 + kontener.SelfWeight/1000 + GetWeight()/1000 < MaxWeightOfKonteners)
            {
                Kontenery.Add(kontener);
            }
            else
            {
                throw new OverfillException();
            }
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e + " in " + kontener.NumerSeryjny);
        }
    }
    public void Zaladuj(List<Kontener> kontenery)
    {
        List<Kontener> temp = new List<Kontener>();
        foreach (var kontener in kontenery)
        {

            try
            {

                if (kontener.Weight / 1000 + kontener.SelfWeight / 1000 + GetWeight() / 1000 < MaxWeightOfKonteners)
                {
                    temp.Add(kontener);
                }
                else
                {
                    throw new OverfillException();
                }
            }
            catch (OverfillException e)
            {
                Console.WriteLine(e + " in " + kontener.NumerSeryjny);
                break;
            }
        }

        foreach (var kont in temp)
        {
            Kontenery.Add(kont);
        }
    }

    public double GetWeight()
    {
        double weight = 0;
        //if (Kontenery != null)
       //{
            foreach (var i in Kontenery)
            {
                weight += i.Weight + i.SelfWeight;
            }
        //}

        return weight;
    }

    public void GetKonteners()
    {
        int counter = 0;
        foreach (var kont in Kontenery)
        {
            Console.Write(counter + " ");
            kont.ShowInfo();
            counter++;
        }
    }

    public void RemoveKontener(int Number)
    {
        Kontenery.RemoveAt(Number);
        GetKonteners();
    }

    public void ChangeKontener(int number, Kontener kont)
    {
        Kontenery[number] = kont;
        GetKonteners();
    }

    public void TransferKontener(int number, Kontenerowec kontenerowec)
    {
        try
        {
            kontenerowec.Zaladuj(Kontenery[number]);
            Kontenery.RemoveAt(number);
        }
        catch (OverfillException e)
        {
            Console.WriteLine(e);
        }
    }

    public void getInfo()
    {
        Console.WriteLine("Speed: " + MaxSpeed + " " + "Max Konteners amount: " + MaxAmountKonteners + " "+ "Konteners amount: " + Kontenery.Count+ " " + " " + "Max weight: " + MaxWeightOfKonteners);
        Console.WriteLine("Konteners: ");
        GetKonteners();
    }





}