using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void TriangleType_CheckForTriangleCLargest_NotATriangle()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("not a triangle", testTriangle.TriangleType(5, 5, 50));
    }
    [TestMethod]
    public void TriangleType_CheckForTriangleBLargest_NotATriangle()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("not a triangle", testTriangle.TriangleType(5, 50, 5));
    }

    public void TriangleType_CheckForTriangleALargest_NotATriangle()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("not a triangle", testTriangle.TriangleType(50, 5, 5));
    }
    
  }
}