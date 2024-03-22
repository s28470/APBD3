namespace apbdProj3;

public class RefrigeratedContainer : AbstractContainer
{
    
    public ProductInfo ProductInformation { get; }
    
    public string CargoType { get; }
    
    public double Temperature { get; }

    public RefrigeratedContainer(double height, double selfMass, double depth, double capacity, string cargoType, double temperature) : base(height, selfMass, depth, capacity)
    {
        Serial = "KON" + "-C-" + Id;
        CargoType = cargoType;
        Temperature = temperature;
    }


    public override string Serial { get; }

    public override void Load(double mass)
    {
        if (ProductInformation is null)
        {
            Console.WriteLine("NO INFO ABOUT PRODUCT" + "in container nr " + Id);
            return;
        }

        if (!ProductInformation.Name.Equals(CargoType))
        {
            Console.WriteLine("NOT CORRECT PRODUCT");
            return;
        }

        if (Temperature < ProductInformation.Temperature)
        {
            Console.WriteLine("TEMPERATURE IS TOO LOW");
            return;
        }
        
        base.Load(mass);
        CargoMass += mass;




    }
}

public class ProductInfo
{
    public string Name { get; set; }
    public double Temperature { get; set; }

    public ProductInfo(string name, double temperature)
    {
        Name = name;
        Temperature = temperature;
    }
}