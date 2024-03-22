namespace apbdProj3;

public class LiquidContainer : AbstractContainer,IHazardNotifier
{
    
    
    public string CargoType { get; }
    public bool CargoSafe { get; }
    public override string Serial { get; }


    public LiquidContainer(double height, double selfMass, double depth, double capacity, string cargoType, bool cargoSafe) : base(height, selfMass, depth, capacity)
    {
        CargoType = cargoType;
        CargoSafe = cargoSafe;
    }

    public override void Unload()
    {
        base.Unload();
    }

    public override void Load(double mass)
    {
        base.Load(mass);
        
        if (CargoSafe)  
        {
            if (CargoMass + mass <= Capacity * 0.9)
            {
                CargoMass += mass;
                return;
            }
            else
            {
                SendHazardNotify();
                return;
            }
        }

        if (!CargoSafe)
        {
            if (CargoMass + mass <= Capacity * 0.5)
            {
                CargoMass += mass;
                return;
            }
            else
            {
                SendHazardNotify();
                return;
            }
        }
        
        
        
    }

    public void SendHazardNotify()
    {
        Console.WriteLine("Unsafe situation in container : " + Id);
    }
}

public interface IHazardNotifier
{
    void SendHazardNotify();
}