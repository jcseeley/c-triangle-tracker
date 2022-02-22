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
      else
      {
        return "is a triangle";
      }
    }
    
  }
}