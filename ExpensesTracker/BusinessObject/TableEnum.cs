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
            LOGIN_INFO,
            CODE_VALUE,
            HUSBAND_WIFE,
            EXPENSES_CATEGORY,
            EXPENSES_TRACKER
        }

        public enum enmLogin_Info
        {
            LOGIN_INFO_ID,
            USERNAME,
            PASSWORD,
            FIRST_NAME,
            LAST_NAME,
            GENDER
        }

        public enum enmCode_Value
        {
            CODE_SERIAL_ID,
            CODE_ID,
            CODE_VALUE,
            CODE_VALUE_DESCRIPTION,
            DATA1,
            DATA2
        }

        public enum enmHusband_Wife
        {
            HUSBAND_WIFE_ID,
            HUSBAND_WIFE_TYPE_ID,
            HUSBAND_WIFE_TYPE_VALUE,
            HUSBAND_WIFE_AMT,
            HUSBAND_WIFE_DATE,
            EXPENSES_CATEGORY_ID
        }

        public enum enmExpenses_Category
        {
            EXPENSES_CATEGORY_ID,
            EXPENSES_CATEGORY_NAME,
            EXPENSES_CATEGORY_TABLE_ID,
            EXPENSES_CATEGORY_TABLE_VALUE
        }

        public enum enmExpenses_Tracker
        {
            EXPENSES_TRACKER_ID,
            EXPENSES_ITEM,
            EXPENSES_DATE,
            EXPENSES_AMT,
            EXPENSES_CATEGORY_ID,
            EXPENSES_TYPE_ID,
            EXPENSES_TYPE_VALUE,
            LOGIN_ID
        }

        public enum Month
        {
            NotSet = 0,
            January = 1,
            February = 2,
            March = 3,
            April = 4,
            May = 5,
            June = 6,
            July = 7,
            August = 8,
            September = 9,
            October = 10,
            November = 11,
            December = 12
        }
    }
}
