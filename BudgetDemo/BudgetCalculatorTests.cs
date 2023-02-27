using System;
using System.Collections.Generic;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace BudgetDemo
{
    public class BudgetCalculatorTests
    {
        private readonly BudgetCalculator _target;
        private readonly IServiceRepository _service;

        public BudgetCalculatorTests()
        {
            _service = Substitute.For<IServiceRepository>();
            _target = new BudgetCalculator(_service);
        }

        [Fact]
        public void Success_when_sameMonth_dayOne()
        {
            //Arrange
            var start = new DateTime(2023, 1, 1);
            var end = new DateTime(2023, 1, 1);
            GivenBudgets();

            //Act
            var actual = _target.CalculateBudget(start, end);

            //Assert
            actual.Should().Be(100);
        }

        [Fact]
        public void Success_when_sameMonth_TwoDays()
        {
            //Arrange
            var start = new DateTime(2023, 1, 1);
            var end = new DateTime(2023, 1, 2);
            GivenBudgets();

            //Act
            var actual = _target.CalculateBudget(start, end);

            //Assert
            actual.Should().Be(200);
        }

        [Fact]
        public void Success_when_differentMonths()
        {
            //Arrange
            var start = new DateTime(2023, 1, 31);

            var end = new DateTime(2023, 5, 2);
            GivenBudgets();

            //Act
            var actual = _target.CalculateBudget(start, end);

            //Assert
            actual.Should().Be(120);
        }

        private void GivenBudgets()
        {
            _service.GetBudgets().Returns(new List<Budget>()
            {
                new Budget {Month = "202301", Amount = 3100},
                new Budget {Month = "202302", Amount = 0},
                new Budget {Month = "202305", Amount = 310},
            });
        }
    }
}