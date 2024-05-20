using global::TestingLab1;
using NUnit.Framework;

namespace TestProjectLab1
{
    [TestFixture]
    public class Lab1Tests
    {
        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� �������� � ������� ��� ������������� �����.
        [Test]
        public void SquareNonNegativeNumbers_AllPositiveNumbers_ReturnsSquaredNumbers()
        {
            double[] numbers = { 2.5, 3.7, 4.2 };
            double[] expected = { 6.25, 13.69, 17.64 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            for (int i = 0; i < expected.Length; i++)
            {
                Assert.AreEqual(expected[i], result[i], 0.0001);
            }
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ������ �������� ������������� ����� ��� ���������.
        [Test]
        public void SquareNonNegativeNumbers_AllNegativeNumbers_ReturnsOriginalNumbers()
        {
            double[] numbers = { -2.5, -3.7, -4.2 };
            double[] expected = { -2.5, -3.7, -4.2 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            CollectionAssert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� ������������ ��������� ������ � �������������� � �������������� �������.
        [Test]
        public void SquareNonNegativeNumbers_MixedPositiveAndNegativeNumbers_ReturnsSquaredAndOriginalNumbers()
        {
            double[] numbers = { 2.5, -3.7, 4.2, -5.0, 6.3 };
            double[] expected = { 6.25, -3.7, 17.64, -5.0, 39.69 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� ������������ ����.
        [Test]
        public void SquareNonNegativeNumbers_Zero_ReturnsZero()
        {
            double[] numbers = { 0 };
            double[] expected = { 0 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� ������������ ������ ������.
        [Test]
        public void SquareNonNegativeNumbers_EmptyArray_ReturnsEmptyArray()
        {
            double[] numbers = new double[0];
            double[] expected = new double[0];

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� ������������ ������� ������������� �����.
        [Test]
        public void SquareNonNegativeNumbers_LargePositiveNumber_ReturnsSquaredNumber()
        {
            double[] numbers = { 1000000 };
            double[] expected = { 1000000000000 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ������ ������� ������������� ����� ��� ���������.
        [Test]
        public void SquareNonNegativeNumbers_LargeNegativeNumber_ReturnsOriginalNumber()
        {
            double[] numbers = { -1000000 };
            double[] expected = { -1000000 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� ������������ ���������� �����.
        [Test]
        public void SquareNonNegativeNumbers_DecimalNumbers_ReturnsSquaredNumbers()
        {
            double[] numbers = { 1.5, 2.25, 3.5 };
            double[] expected = { 2.25, 5.0625, 12.25 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ������ ������������� ���� ��� ���������.
        [Test]
        public void SquareNonNegativeNumbers_NegativeZero_ReturnsOriginalNumber()
        {
            double[] numbers = { -0.0 };
            double[] expected = { -0.0 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }

        // ���� ���������, ��� ����� SquareNonNegativeNumbers ��������� ������������ ������, ���������� ������ ����.
        [Test]
        public void SquareNonNegativeNumbers_AllZeroes_ReturnsZeroes()
        {
            double[] numbers = { 0.0, 0.0, 0.0 };
            double[] expected = { 0.0, 0.0, 0.0 };

            double[] result = Lab1.SquareNonNegativeNumbers(numbers);

            Assert.AreEqual(expected, result);
        }
    }
}