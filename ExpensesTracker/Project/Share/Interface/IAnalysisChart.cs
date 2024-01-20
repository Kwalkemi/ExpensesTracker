using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExpensesTracker.Project.Share.Business;

namespace ExpensesTracker.Project.Share.Interface
{
    internal interface IAnalysisChart
    {
        DataTable FetchDataFromTable();
        DataTable GetDataTableFromQueryData(DataTable adtbTable);

    }
}
