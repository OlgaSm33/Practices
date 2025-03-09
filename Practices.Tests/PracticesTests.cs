namespace Practices.Tests
{
    public class PracticesTests
    {
        /// <summary>
        /// тесты для Additional
        /// </summary>
        [Test]
        public void Additional_TwoPositiveNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(7, 5), Is.EqualTo(12));

        }

        [Test]
        public void Additional_PositiveAndNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(12, -5), Is.EqualTo(7));

        }

        [Test]
        public void Additional_TwoNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(-12, -5), Is.EqualTo(-17));

        }


        [Test]
        public void Additional_NullAndNumber_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Additional(0, 25), Is.EqualTo(25));

        }





        /// <summary>
        /// тесты для Subtraction
        /// </summary>
        [Test]
        public void Subtraction_TwoPositiveNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(7, 5), Is.EqualTo(2));

        }

        [Test]
        public void Subtraction_PositiveAndNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(12, -5), Is.EqualTo(17));

        }

        [Test]
        public void Subtraction_NegativeAndPositiveNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(-3, 7), Is.EqualTo(-10));

        }

        [Test]
        public void Subtraction_TwoNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(-12, -5), Is.EqualTo(-7));

        }


        [Test]
        public void Subtraction_NullAndNumber_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Subtraction(0, 25), Is.EqualTo(-25));

        }






        /// <summary>
        /// тесты для Multiplication
        /// </summary>
        [Test]
        public void Multiplication_TwoPositiveNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(7, 5), Is.EqualTo(35));

        }

        [Test]
        public void Multiplication_PositiveAndNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(12, -5), Is.EqualTo(-60));

        }


        [Test]
        public void Multiplication_TwoNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(-12, -5), Is.EqualTo(60));

        }


        [Test]
        public void Multiplication_NullAndNumber_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(0, 25), Is.EqualTo(0));

        }

        [Test]
        public void Multiplication_NullAndNull_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Multiplication(0, 0), Is.EqualTo(0));

        }



        /// <summary>
        /// тесты для Division
        /// </summary>

        [Test]
        public void Division_TwoPositiveNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(8, 3), Is.EqualTo(2));

        }

        [Test]
        public void Division_PositiveAndNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(8, -3), Is.EqualTo(-2));

        }

        [Test]
        public void Division_NegativeAndPositiveNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(-8, 3), Is.EqualTo(-2));

        }


        [Test]
        public void Division_TwoNegativeNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(-8, -3), Is.EqualTo(2));

        }


        [Test]
        public void Division_NullAndNumber_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(0, 25), Is.EqualTo(0));

        }

        [Test]
        public void Division_NumberAndNull_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => {
                calculator.Division(25, 0);
            });
           

        }

        [Test]
        public void Division_NullAndNull_ThrowsException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => {
                calculator.Division(0, 0);
            });

        }

        [Test]
        public void Division_TwoMaxNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(int.MaxValue, int.MaxValue), Is.EqualTo(1));

        }

        [Test]
        public void Division_TwoMinNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(int.MinValue, int.MinValue), Is.EqualTo(1));

        }


        [Test]
        public void Division_MinAndMaxNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(int.MaxValue, int.MinValue), Is.EqualTo(0));

        }


        [Test]
        public void Division_MaxAndMinNumbers_ReturnsCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(int.MinValue, int.MaxValue), Is.EqualTo(-1));

        }


    }
}