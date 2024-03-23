namespace apbdProj3;

public abstract class AbstractContainer
{
    private static int ID = 0;
    public int Id { get; }
    public double CargoMass { get; set; }

    public double Height { get; set; }
    
    public double SelfMass { get; set; }
    
    public double Depth { get; set; }
    public abstract string Serial { get; }


    public double Capacity { get; }

    protected AbstractContainer(double height, double selfMass, double depth, double capacity)
    {
        Id = ++ID;
        CargoMass = 0;
        Height = height;
        SelfMass = selfMass;
        Depth = depth;
        Capacity = capacity;
    }
    public virtual void Unload()
    {
        CargoMass = 0;
    }

    public virtual void Load(double mass)
    {
        if (! IsCargoOk(mass) )
        {
            throw new OverfillException();
        }
    }

    public bool IsCargoOk(double mass)
    {
        return CargoMass + mass <= Capacity;
    }


    public override string ToString()
    {
        return string.Format("Container Serial: {0}, CargoMass: {1}kg, Capacity: {2}kg", Serial, CargoMass,Capacity);
    }
}

public class OverfillException : Exception
{
    
}