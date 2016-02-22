using System;
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
        Animal animal = new Animal();

        string name = nameof(animal.Name);
        string writeLine = nameof(Console.WriteLine);

        Console.WriteLine(name);
        Console.WriteLine(writeLine);
      }
    }
}
