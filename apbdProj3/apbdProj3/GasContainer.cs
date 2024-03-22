namespace apbdProj3;

public class GasContainer : AbstractContainer,IHazardNotifier
{
    public double Pressure { get; }

    public GasContainer(double height, double selfMass, double depth, double capacity, double pressure) : base(height, selfMass, depth, capacity)
    {
        Pressure = pressure;
        Serial = "KON" + "-G-" + Id;

    }


    public override string Serial { get; }

    public override void Unload()
    {
        CargoMass -= 0.95 * CargoMass;
    }

    public override void Load(double mass)
    {
        try
        {
            base.Load(mass);
        }
        catch (Exception e)
        {
            SendHazardNotify();
        }

        CargoMass += mass;
    }

    public void SendHazardNotify()
    {
        Console.WriteLine("Unsafe situation in container : " + Id);
    }
}