using System.ComponentModel;
using apbdProj3;

public class Program
{
    public static void Main(string[] args)
    {
        // Stworzenie kontenera danego typu

        GasContainer c1 = new GasContainer(10, 10, 10, 10, 10);
        LiquidContainer c2 = new LiquidContainer(10, 10, 10, 10, "water", true);
        RefrigeratedContainer c3 = new RefrigeratedContainer(10, 10, 10, 10, "Banana", 10);
        c3.ProductInformation = new ProductInfo("Banana", 9);
        
        // Załadowanie ładunku do danego kontenera
        
        c1.Load(5);
        c2.Load(5);
        c3.Load(5);


        try
        {
            c1.Load(999999);
            c2.Load(999999);
            c3.Load(999999);
        }
        catch (Exception e)
        {
        }

        // Załadowanie kontenera na statek
        Ship s1 = new Ship(100,100,100);
        Ship s2 = new Ship(100,100,100);
        
        s1.AddContainer(c1);
        
        // Załadowanie listy kontenerów na statek
        List<AbstractContainer> containers = new List<AbstractContainer>();
        containers.Add(c2);
        containers.Add(c3);
        s1.AddContainers(containers);
        
        // Usunięcie kontenera ze statku
        
        s1.RemoveContainerById(c1.Id);
        // Rozładowanie kontenera
        c1.Unload();
        
        // Zastąpienie kontenera na statku o danym numerze innym kontenerem
        AbstractContainer c4 = new GasContainer(10, 10, 10, 10, 10);
        s1.ReplaceContainer(c4,c3.Id);
        
        // Możliwość przeniesienie kontenera między dwoma statkami
        s1.MoveContainerBetweenShips(c4.Id,s2);
        // Wypisanie informacji o danym kontenerze
        Console.WriteLine(c1);
        // Wypisanie informacji o danym statku i jego ładunku
        Console.WriteLine(s2);


    }
}

