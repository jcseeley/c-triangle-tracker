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
      } 
      else if (a == b && a != c || a == c && a != b || b == c && b != a)
      {
        return "this is an isosceles triangle";
      }
      else if (a != b && b != c && a != c)
      {
        return "this is a scalene triangle";
      }
      else
      {
        return "please enter 3 numbers";
      }
    }
    
  }
}