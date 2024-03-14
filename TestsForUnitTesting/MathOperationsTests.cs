using TestableProject;
using Xunit;

namespace TestsForUnitTesting
{
    public class MathOperationsTests
    {
        [Fact]
        public void Sum_ReturnsCorrectSum()
        {
            // Arrange
            var mathOperations = new MathOperations();
            int a = 5;
            int b = 7;

            // Act
            var result = mathOperations.Sum(a, b);

            // Assert
            Assert.Equal(12, result);
        }
        [Fact]
        public void Sum_Overflow_ThrowsError()
        {
            // Arrange
            var mathOperations = new MathOperations();
            int a = int.MaxValue;
            int b = 15;

            // Assert
            Assert.Throws<OverflowException>(() => mathOperations.Sum(a, b));

        }

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(0, 0, 0)]
        [InlineData(-1, -2, -3)]
        [InlineData(19998, 1, 19999)]
        public void Sum_WithVariousInputs_ReturnsCorrectSum(int a, int b, int expectedResult)
        {
            // Arrange
            var math = new MathOperations();

            // Act
            var result = math.Sum(a, b);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
