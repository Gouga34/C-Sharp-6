using static System.Console;
using System.Collections.Generic;

namespace CSharpSix
{


    class Program
    {
      static void Main(string[] args)
      {
        var chiens = new Dictionary<string, string>
        {
            ["shana"] = "épagneul",
            ["pepita"] = "croisé fox",
            ["gold"] = "golden",
            ["neska"] = "croisé border",
        };

        WriteLine(chiens["shana"]);
        chiens["mirabelle"] = "épagneul breton";
        WriteLine(chiens["mirabelle"]);
      }
    }
}
