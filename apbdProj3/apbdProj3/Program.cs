using System.ComponentModel;
using apbdProj3;

public class Program
{
    public static void Main(string[] args)
    {
        AbstractContainer liquidContainer = new LiquidContainer(100,100,100,100,"water", false);
        AbstractContainer refrigeratedContainer = new RefrigeratedContainer(100,100,100,100,"banana", 8.2);
        
        liquidContainer.Load(49);
        refrigeratedContainer.Load(0);
    }
}

