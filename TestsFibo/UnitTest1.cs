using Fibo3;

namespace TestsFibo
{
    public class UnitTest1
    {
        [Fact]
        public void Test01()
        {
            // Arrange
            var fib = new Fibonacci();

            // Act
            var result = fib.Calculate(1);

            // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void Test02()
        {
            // Arrange
            var fib = new Fibonacci();

            // Act
            var result = fib.Calculate(1);

            // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void Test03()
        {
            // Arrange
            var fib = new Fibonacci();

            // Act
            var result = fib.Calculate(2);

            // Assert
            Assert.Equal(1, result);

        }


        [Fact]
        public void Test04()
        {
            // Arrange
            var fib = new Fibonacci();

            // Act
            var result = fib.Calculate(5);

            // Assert
            Assert.Equal(5, result);

        }


        [Fact]
        public void Test05()
        {
            // Arrange
            var fib = new Fibonacci();

            // Act
            var result = fib.Calculate(9);

            // Assert
            Assert.Equal(34, result);

        }
    }
}