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
            var calculator = new Calculator();
            Assert.That(calculator.Additional(7, 5), Is.EqualTo(12));

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
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(7, 5), Is.EqualTo(2));

        }
        #endregion

        #region Multiplication Tests
        [TestCase(7, 5, 2)]
        [TestCase(12, -5, 17)]
        [TestCase(-3, 7, -10)]
        [TestCase(-12, -5, -7)]
        [Test]
        public void Multiplication_ValidInputs_ReturnsCorrectValue(int x, int y, int expected)
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(7, 5), Is.EqualTo(35));

        }
        #endregion

        #region Division Tests
        [TestCase(7, 5, 35)]
        [TestCase(12, -5, -60)]
        [TestCase(-12, -5, 60)]
        [TestCase(0, 25, 0)]
        [Test]
        public void Division_ValidInputs_ReturnsCorrectValue(int x, int y, int expected)
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(8, 3), Is.EqualTo(2));

        }

        [Test]
        public void Division_NumberAndZero_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => {
                calculator.Division(25, 0);
            });
           

        }
        #endregion

    }
}