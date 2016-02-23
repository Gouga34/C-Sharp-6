using static System.Console;
namespace CSharpSix
{

  class Animal
  {
    public string Name{get;set;}
    public int Age{get;set;}

    public bool IsDog()
    {
      return true;
    }
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

        int? age1 = animal1?.Age; // null si animal est null
        WriteLine(age1);

        int age2 = animal1?.Age ?? 0; // 0 si animal est null
        WriteLine(age2);

        if(animal2?.IsDog() ?? false)
        {
          WriteLine("Dog");
        } else {
          WriteLine("Not a dog");
        }
      }
    }
}
