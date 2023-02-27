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
            decimal budgets;

            if (SameMonth(start, end))
            {
                //同月 
                //1.找出預算
                var budget = QueryMonthlyBudget(start);

                //2.找出當月天數
                var daysInMonth = FindDaysInMonth(start);

                //3.分配給每天 與 計算天數
                budgets = budget.Amount / daysInMonth * ((end - start).Days + 1);

                return budgets;
            }
            else
            {
                // 計算開始月份的預算
                var startBudget = QueryMonthlyBudget(start);

                //2.找出當月天數
                var daysInMonth = FindDaysInMonth(start);

                //3.分配給每天 與 計算天數
                budgets = (startBudget.Amount / daysInMonth) * ((daysInMonth - start.Day) + 1);

                // 計算中間月份的預算
                var endDate = new DateTime(end.Year, end.Month, 1);
                for(var month = start.AddMonths(1); month < endDate; month = month.AddMonths(1))
                {
                    var budget = QueryMonthlyBudget(month);
                    if (budget != null)
                    {
                        daysInMonth = DateTime.DaysInMonth(month.Year, month.Month);
                        budgets += budget.Amount / daysInMonth * daysInMonth;
                    }
                }

                // 計算結束月份的預算
                var endBudget = QueryMonthlyBudget(end);

                //2.找出當月天數
                var endDaysInMonth = FindDaysInMonth(end);

                //3.分配給每天 與 計算天數
                var endBudgetAmount = endBudget.Amount / endDaysInMonth * end.Day;
                budgets += endBudgetAmount;
                return budgets;
            }
        }

        private  int FindDaysInMonth(DateTime start)
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