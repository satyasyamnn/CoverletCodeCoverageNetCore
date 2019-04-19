using System;
using FluentAssertions;
using Xunit;

namespace Calculator.Tests
{
    public class CalculatorTests
    {
        [Theory]
        [InlineData(1, 1, 2)]
        [InlineData(2, 2, 4)]
        [InlineData(5, 5, 11)]
        [InlineData(-1, 2, 1)]
        [InlineData(11, 1, 13)]
        [InlineData(22, 22, 45)]
        public void TestResultForAddition(int x, int y, int result)
        {
            Calculator c = new Calculator();
            c.Add(x, y).Should().Be(result);
        }
    }
}
