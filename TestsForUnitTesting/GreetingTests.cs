using TestableProject;

namespace TestsForUnitTesting
{
    public class GreetingTests
    {
        [Theory]
        [InlineData("John", "Hello, John")]
        [InlineData("", "Hello, ")]
        [InlineData("Doe", "Hello, Doe")]
        public void SayHello_WithDifferentNames_ReturnsCorrectGreeting(string name, string expectedResult)
        {
            // Arrange
            var math = new Greeting();

            // Act
            var result = math.SayHello(name);

            // Assert
            Assert.Equal(expectedResult, result);
        }
    }
}
