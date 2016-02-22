using static System.Console;
namespace CSharpSix
{

  class Animal
  {
    public string Name{get;set;}
  }
    class Program
    {
      static void Main(string[] args)
      {
        Animal animal1 = new Animal();
        animal1.Name="Shana";
        string animal1Name = animal1?.Name;
        WriteLine(animal1Name);

        Animal animal2 = null;
        string animal2Name = animal2?.Name;
        WriteLine(animal2Name);
      }
    }
}
