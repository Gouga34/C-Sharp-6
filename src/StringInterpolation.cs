using static System.Console;
namespace CSharpSix
{
    class Program
    {
      static void Main(string[] args)
      {
        var name = "Shana";
        var breed = "Epagneul breton";

        var str = $"{name} est un {breed}";
        WriteLine(str);
      }
    }
}
