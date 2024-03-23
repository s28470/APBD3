using System.ComponentModel;

namespace apbdProj3;

public class Ship
{
    private List<AbstractContainer> Containers { get; }
    
    public int MaxContainers { get; set; }
    
    public double MaxSpeed { get; set; }

    public double MaxWeight { get; set; }

    public Ship(int maxContainers, double maxSpeed, double maxWeight)
    {
        Containers = new List<AbstractContainer>();
        MaxContainers = maxContainers;
        MaxSpeed = maxSpeed;
        MaxWeight = maxWeight;
    }


    public void AddContainers(List<AbstractContainer> containers)
    {
        if (!IsSheepFull(containers))
        {
            Containers.AddRange(containers);
        }
    }

    public void RemoveContainerById(int id)
    {
        Containers.RemoveAt(id);
    }

    public void ReplaceContainer(AbstractContainer container, int id)
    {
        var containerById = GetContainerById(id);
        Containers.Remove(containerById);
        Containers.Add(container);
    }

    public void MoveContainerBetweenShips(int id,Ship ship)
    {
        var containerById = GetContainerById(id);
        Containers.Remove(containerById);
        ship.Containers.Add(containerById);
        
    }

    public void AddContainer(AbstractContainer container)
    {
        if (!IsSheepFull(container))
        {
            Containers.Add(container);
        }
    }

    public AbstractContainer GetContainerById(int id)
    {
        foreach (var abstractContainer in Containers)
        {
            if (abstractContainer.Id == id)
            {
                return abstractContainer;
            }
        }

        Console.WriteLine("no such container");
        return null;
    }

    private double GetContainersMass()
    {
        double mass = 0;
        foreach (var abstractContainer in Containers)
        {
            mass += abstractContainer.CargoMass + abstractContainer.SelfMass;
        }
        return mass;
    }

    private bool IsSheepFull (AbstractContainer container)
    {
        bool notEnoughPlace = Containers.Count + 1 > MaxContainers;
        bool tooBigMass = GetContainersMass() + container.CargoMass + container.SelfMass > MaxWeight * 1000;

        return notEnoughPlace || tooBigMass;
    }

    private bool IsSheepFull(List<AbstractContainer> containers)
    {
        double sumMass = 0;
        int len = containers.Count;
        if (Containers.Count + len > MaxContainers)
        {
            return true;
        }
        
        foreach (var abstractContainer in containers)
        {
            sumMass += abstractContainer.CargoMass + abstractContainer.SelfMass;
        }

        return GetContainersMass() + sumMass >= MaxWeight * 1000;
    }

    public override string ToString()
    {
        return string.Format("Ship MaxWeight: {0}t, CargoMass :{1}kg, Cargo :({2})", MaxWeight, GetContainersMass(),
            string.Join(", ", Containers));
    }
}