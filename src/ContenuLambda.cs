using static System.Console;
namespace CSharpSix
{

  class Point
  {
    public int PointA{get;set;}
    public int PointB{get;set;}
    public int Distance => (int)(PointA-PointB);

    public void SayHello() => WriteLine("Hello world");
  }
    class Program
    {
      static void Main(string[] args)
      {
        Point p = new Point();
        p.PointA = 5;
        p.PointB = 3;
        p.SayHello();
        WriteLine(p.Distance);
      }
    }
}
