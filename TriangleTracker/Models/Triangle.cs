namespace Triangle
{
  public class TriangleTracker 
  {
    public string TriangleType(int a, int b, int c)
    {
      if (a + b < c || a + c < b || b + c < a)
      {
        return "not a triangle";
      }
      else if (a==b && b==c)
      {
        return "this is an equilateral triangle";
      } else if (a == b && a != c)
      {
        return "this is an isosceles triangle";
      }
      else
      {
        return "is a triangle";
      }
    }
    
  }
}