namespace Interfaces;

public class Person
{
   private ILogger logger = new ConsoleLogger();

   private string name;
   
   public string Name
   {
      get
      { 
         logger.Log("Der Getter von Name wurde aufgerufen!");
         return name;
      }
      set
      {
         logger.Log("Der Setter von Name wurde aufgerufen!");
         name = value;
      }
   }
}