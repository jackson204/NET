using System;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace BudgetDemo
{
    public class BudgetCalculatorTests
    {
        private BudgetCalculator _target;

        public BudgetCalculatorTests()
        {
            
            _target = new BudgetCalculator();
        }

        [Fact]
        public void OneDay()
        {
            //Arrange
            var start = new DateTime(2023, 1, 1);
            var end = new DateTime(2023, 1, 1);

            //Act
            var actual = _target.CalculateBudget(start, end);

            //Assert
            actual.Should().Be(100);
        }
    }
}