using System.Collections.Generic;

namespace BudgetDemo
{
    public interface IServiceRepository
    {
        List<Budget> GetBudgets();
    }

    public class Budget
    {
        public string Month { get; set; }

        public decimal Amount { get; set; }
    }
}