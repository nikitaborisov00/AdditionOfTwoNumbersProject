using LibraryAddNumbers;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace UnitTestAddOfTwoNumbers
{
    [TestClass]
    public class UnitTestSumNumbers
    {
        [TestMethod]
        public void TestMethodSumNumbers()
        {
            // arrange
            double par1 = 3.5;
            double par2 = 12.7;
            double result = 16.2;
            // act
            var actual = SumNumber.Add(par1, par2);
            // assert
            Assert.AreEqual(result, actual, 0.01);
        }
    }
}
