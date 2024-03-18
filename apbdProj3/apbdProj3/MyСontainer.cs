namespace apbdProj3;

public abstract class MyСontainer
{
   private static int ID = 0;
   
   protected int Id { get; }
   
   protected string Serial { get; }
   
   protected double Mass { get; }
   
   protected double Height { get; }
   
   protected double SelfMass { get; }

   protected double Depth { get; }
   
   protected double Capacity { get; }


   protected MyСontainer(double mass, double height, double selfMass, double depth, double capacity)
   {
      Mass = mass;
      Height = height;
      SelfMass = selfMass;
      Depth = depth;
      Capacity = capacity;
   }
   
   
}

public class OverfillException : Exception
{
    
}