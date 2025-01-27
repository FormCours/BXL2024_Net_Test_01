using DemoTesting.BLL.CustomExceptions;
using DemoTesting.BLL.Interfaces;
using DemoTesting.BLL.Services;

namespace DemoTesting.BLL.Test.Services
{
    public class CalculatorServiceTest
    {
        #region Tools
        private ICalculatorService GetCalculatorService()
        {
            return new CalculatorService();
        }
        #endregion

        #region Addition
        [Fact]
        public void Addition_TwoInteger_Ok()
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            const int val1 = 5;
            const int val2 = 2;
            const int expected = 7;

            // Action
            int actual = service.Addition(val1, val2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_TwoReal_Ok()
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            const double val1 = 0.9;
            const double val2 = 0.3;
            const double expected = 1.2;

            // Action
            double actual = service.Addition(val1, val2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void Addition_TwoReal_BugPrecision_IEEE754()
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();
            const double val1 = 0.1;
            const double val2 = 0.2;
            const double expected = 0.3;

            // Action
            double actual = service.Addition(val1, val2);

            // Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(int.MaxValue, 42)]
        [InlineData(int.MinValue, -42)]
        public void Addition_TwoInteger_ExceptionOnOverflow(int val1, int val2)
        {
            // Arrange
            ICalculatorService service = GetCalculatorService();

            // Action + Assert
            Assert.Throws<CalculatorOverflowException>(() =>
            {
                service.Addition(val1, val2);
            });
        }
        #endregion
    }
}
