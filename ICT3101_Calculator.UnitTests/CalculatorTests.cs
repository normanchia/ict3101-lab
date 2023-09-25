namespace ICT3101_Calculator.UnitTests
{
    public class CalculatorTests
    {
        private Calculator _calculator;

        [SetUp]
        public void Setup()
        {
            //Arrange
            _calculator = new Calculator();
        }

        [Test]
        public void Add_WhenAddingTwoNumbers_ResultEqualToSum()
        {
            //Act
            double result = _calculator.Add(10, 20);
            Assert.That(result, Is.EqualTo(30));
        }

        [Test]
        public void Subtract_WhenSubtractTwoNumbers_ResultEqualToSum()
        {
            //Act
            double result = _calculator.Subtract(30, 10);
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void Multiply_WhenMultiplyTwoNumbers_ResultEqualToSum()
        {
            //Act
            double result = _calculator.Multiply(10, 20);
            Assert.That(result, Is.EqualTo(200));
        }

        [Test]
        public void Divide_WithZeroAsInputs_ResultThrowArgumentException()
        {
            Assert.That(() => _calculator.Lab1_Divide(0, 0), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0, 0)]
        [TestCase(0, 10)]
        [TestCase(10, 0)]
        public void Divide_WithZerosAsInputs_ResultThrowArgumentException(double a, double b)
        {
            Assert.That(() => _calculator.Lab1_Divide(a, b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(5, 120)]
        [TestCase(0, 1)]
        [TestCase(1, 1)]
        [TestCase(10, 3628800)]
        public void Factorial_ValidInput_ReturnsExpectedResult(int n, int expected)
        {
            int result = _calculator.Factorial(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        [TestCase(-1)]
        [TestCase(-5)]
        public void Factorial_NegativeInput_ResultThrowsArgumentException(int n)
        {
            Assert.That(() => _calculator.Factorial(n), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(120));
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionA(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(60));
        }

        [Test]
        public void UnknownFunctionA_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionA_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionA(4, 5), Throws.ArgumentException);
        }

        [Test]
        public void UnknownFunctionB_WhenGivenTest0_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 5);
            // Assert
            Assert.That(result, Is.EqualTo(1));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest1_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 4);
            // Assert
            Assert.That(result, Is.EqualTo(5));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest2_Result()
        {
            // Act
            double result = _calculator.UnknownFunctionB(5, 3);
            // Assert
            Assert.That(result, Is.EqualTo(10));
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest3_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(-4, 5), Throws.ArgumentException);
        }
        [Test]
        public void UnknownFunctionB_WhenGivenTest4_ResultThrowArgumnetException()
        {
            // Act
            // Assert
            Assert.That(() => _calculator.UnknownFunctionB(4, 5), Throws.ArgumentException);
        }

        [Test]
        [TestCase(-20, 5)]
        [TestCase(15, -7)]
        public void Triangle_NegativeInput_Result(double b, double h)
        {
            Assert.That(() => _calculator.Triangle(b, h), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0, 5)]
        [TestCase(15, 0)]
        [TestCase(0, 0)]
        public void Triangle_ZeroInput_Result(double b, double h)
        {
            Assert.That(() => _calculator.Triangle(b, h), Throws.ArgumentException);
        }

        [Test]
        [TestCase(20, 5, 50)]
        [TestCase(15, 7, 52.5)]
        [TestCase(26, 7, 91)]
        public void Triangle_ValidInput_Result(double b, double h, double area)
        {
            double result = _calculator.Triangle(b, h);
            Assert.That(result, Is.EqualTo(area));
        }

        [Test]
        [TestCase(-20)]
        public void Circle_NegativeInput_Result(double b)
        {
            Assert.That(() => _calculator.Circle(b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(0)]
        public void Circle_ZeroInput_Result(double b)
        {
            Assert.That(() => _calculator.Circle(b), Throws.ArgumentException);
        }

        [Test]
        [TestCase(5, 78.55)]
        [TestCase(6, 113.112)]
        public void Circle_ValidInput_Result(double b, double area)
        {
            double result = _calculator.Circle(b);
            Assert.That(result, Is.EqualTo(area));
        }
    }
}