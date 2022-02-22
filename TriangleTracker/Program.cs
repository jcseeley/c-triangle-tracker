using System;
using Triangle;

namespace Triangle
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Enter a number: ");
      int a = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a number: ");
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter a number: ");
      int c = int.Parse(Console.ReadLine());
      TriangleTracker myTriangle = new TriangleTracker();
      Console.WriteLine(myTriangle.TriangleType(a,b,c));
    }
  }
}