namespace Practices.Tests
{
    [TestFixture]
    public class PracticesTests
    {

        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }


        #region Additional Tests
        [TestCase(7, 5, 12)]
        [TestCase(12, -5, 7)]
        [TestCase(-12, -5, -17)]
        [TestCase(0, 25, 25)]
        [Test]
        public void Additional_ValidInputs_ReturnsCorrectValue(int x, int y, int expected)
        {
            Assert.That(calculator.Additional(x, y), Is.EqualTo(expected));

        }
        #endregion

        #region Subtraction Tests
        [TestCase(7, 5, 2)]
        [TestCase(12, -5, 17)]
        [TestCase(-3, 7, -10)]
        [TestCase(-12, -5, -7)]
        [Test]
        public void Subtraction_ValidInputs_ReturnsCorrectValue(int x, int y, int expected)
        {
            Assert.That(calculator.Subtraction(x, y), Is.EqualTo(expected));

        }
        #endregion

        #region Multiplication Tests
        [TestCase(7, 5, 35)]
        [TestCase(12, -5, -60)]
        [TestCase(-12, -5, 60)]
        [TestCase(0, 25, 0)]
        [Test]
        public void Multiplication_ValidInputs_ReturnsCorrectValue(int x, int y, int expected)
        {
            Assert.That(calculator.Multiplication(x, y), Is.EqualTo(expected));

        }
        #endregion

        #region Division Tests
        [TestCase(8, 3, 2)]
        [TestCase(8, -3, -2)]
        [TestCase(-8, -3, 2)]
        [TestCase(0, 25, 0)]
        [Test]
        public void Division_ValidInputs_ReturnsCorrectValue(int x, int y, int expected)
        {
            Assert.That(calculator.Division(x, y), Is.EqualTo(expected));

        }

        [Test]
        public void Division_NumberAndZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => {
                calculator.Division(25, 0);
            });
           

        }
        #endregion

    }
}