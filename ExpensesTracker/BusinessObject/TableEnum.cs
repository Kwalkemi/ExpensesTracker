using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.BusinessObject
{
    public class TableEnum
    {
        public enum enmTableName
        {
            Login_Info
        }

        public enum enmLogin_Info
        {
            Username,
            Password,
            First_Name,
            Last_Name,
            Gender
        }
    }
}
