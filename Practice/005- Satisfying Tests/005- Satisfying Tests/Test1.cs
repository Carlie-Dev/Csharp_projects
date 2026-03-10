//allow test to see calculator
using _005__Calculator;
namespace _005__Satisfying_Tests
{
    [TestClass]
    public sealed class Test1
    {
       private Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            // Arrange
            _calculator = new Calculator();
        }

        [TestMethod]
        public void Add_ShouldReturnSum()
        {
            // Act
            var result = _calculator.Add(5, 7);

            // Assert
            Assert.AreEqual(12, result);
        }

        [TestMethod]
        public void Subtract_ShouldReturnDifference()
        {
            // Act
            var result = _calculator.Subtract(10, 5);

            // Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void Multiply_ShouldReturnProdeuct()
        {
            // Act
            var result = _calculator.Multiply(10, 5);

            // Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void Division_DivideByZeroShouldGiveError()
        {
            // Assert
            Assert.ThrowsException<DivideByZeroException>(() => _calculator.Divide(7, 0));
        }
    }
}
