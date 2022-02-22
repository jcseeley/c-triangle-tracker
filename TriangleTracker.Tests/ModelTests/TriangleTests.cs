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
      TraingleTracker testTriange = new TriangleTracker();
      Assert.AreEqual(true, testTriange.TriangleType(5, 5, 5));
    }
  }
}