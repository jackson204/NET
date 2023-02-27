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
            return SameMonth(start, end) ? TheSameMonthBudgets(start, end) : DifferentMonthsBudgets(start, end);
        }

        private decimal TheSameMonthBudgets(DateTime start, DateTime end)
        {
            //同月 
            //1.找出預算
            var budget = QueryMonthlyBudget(start);

            //2.找出當月天數
            var daysInMonth = QueryDaysInMonth(start);

            //3.分配給每天 與 計算天數
            return budget.Amount / daysInMonth * ((end - start).Days + 1);
        }

        private decimal DifferentMonthsBudgets(DateTime start, DateTime end)
        {
            return CalculateTheBudgetForTheStartMonth(start) + 
                CalculateTheBudgetForTheInterimMonths(start, end) + 
                CalculateTheBudgetForTheEndMonth(end);
        }

        private decimal CalculateTheBudgetForTheEndMonth(DateTime end)
        {
            var endBudget = QueryMonthlyBudget(end);

            //2.找出當月天數
            var endDaysInMonth = QueryDaysInMonth(end);

            //3.分配給每天 與 計算天數
            return endBudget.Amount / endDaysInMonth * end.Day;
        }

        private decimal CalculateTheBudgetForTheInterimMonths(DateTime start, DateTime end)
        {
            var endDate = new DateTime(end.Year, end.Month, 1);
            decimal budgets = 0;
            for(var month = start.AddMonths(1); month < endDate; month = month.AddMonths(1))
            {
                var budget = QueryMonthlyBudget(month);
                if (budget == null)
                {
                    continue;
                }
                var daysInMonth = DateTime.DaysInMonth(month.Year, month.Month);
                budgets += budget.Amount / daysInMonth * daysInMonth;
            }
            return budgets;
        }

        private decimal CalculateTheBudgetForTheStartMonth(DateTime start)
        {
            var startBudget = QueryMonthlyBudget(start);

            //2.找出當月天數
            var daysInMonth = QueryDaysInMonth(start);

            //3.分配給每天 與 計算天數
            return startBudget.Amount / daysInMonth * (daysInMonth - start.Day + 1);
        }

        private int QueryDaysInMonth(DateTime start)
        {
            return DateTime.DaysInMonth(start.Year, start.Month);
        }

        private Budget QueryMonthlyBudget(DateTime dateTime)
        {
            return _service.GetBudgets().FirstOrDefault(r => r.Month == dateTime.ToString("yyyyMM"));
        }

        private bool SameMonth(DateTime start, DateTime end)
        {
            return start.ToString("yyyyMM") == end.ToString("yyyyMM");
        }
    }
}