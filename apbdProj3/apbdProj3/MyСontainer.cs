namespace apbdProj3;

public abstract class MyСontainer
{
   private static int ID = 0;
   
   protected int Id { get; }
   
   protected string Serial { get; set; }
   
   protected double Mass { get; }
   
   protected double Height { get; }
   
   protected double SelfMass { get; }

   protected double Depth { get; }
   
   protected string Type { get; }
   
   protected double Capacity { get; }


   protected MyСontainer(double mass, double height, double selfMass, double depth, double capacity)
   {
      Mass = mass;
      Height = height;
      SelfMass = selfMass;
      Depth = depth;
      Capacity = capacity;
   }

   public abstract void Emptying();

   public virtual void AddCargo(int cargoMass)
   {
      if (!IsMassOk(cargoMass))
      {
         throw new OverfillException();
      }
      
   }

   protected void CreateSerial()
   {
      Serial = "KON-" + Type + "-" + Id;
   }

   public bool IsMassOk(int cargoMass)
   {
      return cargoMass <= Capacity;
   }


}

public class OverfillException : Exception
{
    
}