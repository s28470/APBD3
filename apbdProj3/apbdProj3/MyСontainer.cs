namespace apbdProj3;

public abstract class MyСontainer
{
    private static int ID = 0;

    protected string type;

    private int id;
    
    private double mass = 0;

    private double height;

    private double selfMass;

    private double depth;

    private double capacity;

    private string serial;

    protected MyСontainer( double height, double selfMass, double depth, double capacity)
    {
        this.id = ++ID;
        this.height = height;
        this.selfMass = selfMass;
        this.depth = depth;
        this.capacity = capacity;
        serial = "KON-" + type + "-" + id;
    }


    public abstract void Emptying();

    public void AddContainer(int cargoMass)
    {
        IsMassOk(cargoMass);
    }

    public bool IsMassOk(int cargoMass)
    {
        bool ok = cargoMass <= capacity;
        if (!ok)
        {
            throw new OverfillException();
        }
        return ok;
    }


    public double Mass
    {
        get => mass;
        set => mass = value;
    }

    public double Height
    {
        get => height;
        set => height = value;
    }

    public double SelfMass
    {
        get => selfMass;
        set => selfMass = value;
    }

    public double Depth
    {
        get => depth;
        set => depth = value;
    }

    public double Capacity
    {
        get => capacity;
        set => capacity = value;
    }

    public string Serial
    {
        get => serial;
        set => serial = value;
    }
}

public class OverfillException : Exception
{
    
}