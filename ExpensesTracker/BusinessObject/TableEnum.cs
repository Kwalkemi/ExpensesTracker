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
            HUSBAND_WIFE
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
    }
}
