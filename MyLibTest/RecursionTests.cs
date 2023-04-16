using MyLib;
namespace MyLibTest
{
    [TestClass]
    public class RecursionTests
    {
        [TestMethod]
        public void test_fact()
        {
            var recusrion = new Recursion();

            Assert.AreEqual(24, recusrion.Factorial(4));
            Assert.AreEqual(120, recusrion.Factorial(5));
            Assert.AreEqual(720, recusrion.Factorial(6));
            Assert.AreEqual(-1, recusrion.Factorial(-1));
        }

        [TestMethod]
        public void test_power()
        {
            var recusrion = new Recursion();

            Assert.AreEqual(27, recusrion.Power(3, 3));
            Assert.AreEqual(9, recusrion.Power(3, 2));
        }
    }
}