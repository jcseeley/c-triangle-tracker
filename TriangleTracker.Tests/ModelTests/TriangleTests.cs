using Microsoft.VisualStudio.TestTools.UnitTesting;
using Triangle;

namespace Triangle.Tests
{
  [TestClass]
  public class ClassNameTests
  {
    [TestMethod]
    public void TriangleType_CheckForEquilateral_True()
    {
      TriangleTracker testTriangle = new TriangleTracker();
      Assert.AreEqual(true, testTriangle.TriangleType(5, 5, 5));
    }
  }
}