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
    [TestMethod]
    public void TriangleType_CheckForTriangleALargest_NotATriangle()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("not a triangle", testTriangle.TriangleType(50, 5, 5));
    }
    [TestMethod]
    public void TriangleType_CheckForEquilateral_Equilateral()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("this is an equilateral triangle", testTriangle.TriangleType(5, 5, 5));
    }
    [TestMethod]
    public void TriangleType_CheckForIsoscelesC_Isosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("this is an isosceles triangle", testTriangle.TriangleType(5, 5, 8));
    }
    [TestMethod]
    public void TriangleType_CheckForIsoscelesB_Isosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("this is an isosceles triangle", testTriangle.TriangleType(5, 8, 5));
    }
    [TestMethod]
    public void TriangleType_CheckForIsoscelesA_Isosceles()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("this is an isosceles triangle", testTriangle.TriangleType(8, 5, 5));
    }
    [TestMethod]
    public void TriangleType_CheckForScalene_Scalene()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual("this is a scalene triangle", testTriangle.TriangleType(8, 4, 5));
    }    
  }
}