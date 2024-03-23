using System.ComponentModel;
using apbdProj3;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractContainer liquidContainer = new LiquidContainer(100,100,100,100,"water", false);
        AbstractContainer refrigeratedContainer = new RefrigeratedContainer(100,100,100,100,"banana", 8.2);
        Ship ship = new Ship(3,10,10);
        ship.AddContainer(liquidContainer);
        ship.AddContainer(refrigeratedContainer);
        Console.WriteLine(ship);
    }
}

