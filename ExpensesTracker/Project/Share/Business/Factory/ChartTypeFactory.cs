using ExpensesTracker.Project.Share.Business.ChartTypeProduct;
using ExpensesTracker.Project.Share.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.Project.Share.Business.Factory
{
    internal class ChartTypeFactory
    {
        public int Year { get; set; }
        private string _chartType;
        public ChartTypeFactory(string chartType) {
            _chartType = chartType;
        }

        public IAnalysisChart ChartTypeFactoryMethod()
        {
            IAnalysisChart analysisChart = null;

            if (this._chartType == AnalysisEnum.MONTHLY.ToString())
            {
                analysisChart = new MonthlyChart(Year);
            }
            if (this._chartType == AnalysisEnum.QUARTERLY.ToString())
            {
                analysisChart = new QuarterlyChart();
            }
            if (this._chartType == AnalysisEnum.YEARLY.ToString())
            {
                analysisChart = new YearlyChart();
            }
            return analysisChart;
        }
    }
}
