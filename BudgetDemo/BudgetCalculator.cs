using System;
using System.Linq;

namespace BudgetDemo
{
    public class BudgetCalculator
    {
        private readonly IServiceRepository _service;

        public BudgetCalculator(IServiceRepository service)
        {
            _service = service;
        }

        public decimal CalculateBudget(DateTime start, DateTime end)
        {
            //同月 
            //1.找出預算
            var budget = _service.GetBudgets().FirstOrDefault(r => r.Month == start.ToString("yyyyMM"));

            //2.找出當月天數
            var daysInMonth = DateTime.DaysInMonth(start.Year, start.Month);

            //3.分配給每天 與 計算天數
            return budget.Amount / daysInMonth * ((start - end).Days + 1);
        }
    }
}