namespace SummatorTests
{
    public class CalculaorTests
    {
        //Test Sum method

        [Test]
        public void TestSum_With_TwoPositiveNumbers()
        {
            var numbersArr = new[] {20000, 9};

            var actualSum = Summator.Calculator.Sum(numbersArr);

            Assert.AreEqual(20009, actualSum);
        }

        [Test]
        public void TestSum_With_TwoNegativeNumbers()
        {
            var numbersArr = new[] { -8, -90 };

            var actualSum = Summator.Calculator.Sum(numbersArr);

            Assert.AreEqual(-98, actualSum);
        }

        [Test]
        public void TestSum_With_OneNegative_And_OnePositiveNumber()
        {
            var numbersArr = new[] { -100, 5 };

            var actualSum = Summator.Calculator.Sum(numbersArr);

            Assert.That(actualSum, Is.EqualTo(-95));
        }

        [Test]
        public void TestSum_With_TwoLargeNumbers()
        {
            var numbersArr = new[] { 2147483646, 1 };

            var actualSum = Summator.Calculator.Sum(numbersArr);

            Assert.AreEqual(2147483647, actualSum);
        }

        [Test]
        public void TestSum_With_OneNumber()
        {
            var numbersArr = new[] { 123456789 };

            var actualSum = Summator.Calculator.Sum(numbersArr);

            Assert.AreEqual(123456789, actualSum);
        }

        [Test]
        public void TestSum_With_AddingZero()
        {
            var numbersArr = new[] { 1, 0 };

            var actualSum = Summator.Calculator.Sum(numbersArr);

            Assert.AreEqual(1, actualSum);
        }

        //Test Average method

        [Test]
        public void TestAverage_With_TwoPositiveNumbers()
        {
            var numbersArr = new[] { 1, 3 };

            var actualAverageNumber = Summator.Calculator.Average(numbersArr);

            Assert.AreEqual(2, actualAverageNumber);
        }

        [Test]
        public void TestAverage_With_TwoNegativeNumbers()
        {
            var numbersArr = new[] { -2, -10 };

            var actualAverageNumber = Summator.Calculator.Average(numbersArr);

            Assert.AreEqual(-6, actualAverageNumber);
        }

        [Test]
        public void TestAverage_With_OnePositive_And_OneNegativeNumber()
        {
            var numbersArr = new[] { -2, 10};

            var actualAverageNumber = Summator.Calculator.Average(numbersArr);

            Assert.AreEqual(4, actualAverageNumber);
        }

        [Test]
        public void TestAverage_With_OneNumber()
        {
            var numbersArr = new[] { 99 };

            var actualAverageNumber = Summator.Calculator.Average(numbersArr);

            Assert.AreEqual(99, actualAverageNumber);
        }
    }
}