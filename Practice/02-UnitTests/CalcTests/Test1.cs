using Microsoft.CodeCoverage.Core.Reports.Cobertura;
//allow class to see calculator
using _02_UnitTests;
namespace CalcTests
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void AddShouldReturnSum_WhenPassedTwoNumbers()
        {
            //Arrange
            Calculator calculator = new Calculator();

            int num1 = 5;
            int num2 = 7;

            //Act
            int result = calculator.Add(num1, num2);

            //Assert
            Assert.AreEqual(12, result);
        }
    }
}
