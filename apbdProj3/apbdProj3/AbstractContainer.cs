namespace apbdProj3;

public abstract class AbstractContainer
{
    Icargo Cargo { get;set; }

    double Height { get; set; }

    private double Depth { get; set; }

    public abstract string Serial { get; }

    protected AbstractContainer(Icargo cargo, double height, double depth, double capacity)
    {
        Cargo = cargo;
        Height = height;
        Depth = depth;
        Capacity = capacity;
    }

    private double Capacity { get; }

    public virtual void Unload()
    {
        Cargo = null;
    }

    public virtual void Load(Icargo cargo)
    {
        if (!IsCargoOk(cargo))
        {
            throw new OverfillException();
        }
        
    }

    public bool IsCargoOk(Icargo cargo)
    {
        return cargo.Mass <= Capacity;
    }
    
    
    
    
}

public class OverfillException : Exception
{
    
}