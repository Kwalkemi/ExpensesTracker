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
            EXPENSES_TRACKER,
            SHARES_TRACKER_HEADER,
            SHARES_TRACKER_BUY,
            SHARES_TRACKER_SELL
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

        public enum enmSharesTrackerHeader
        {
            SHARES_TRACKER_HEADER_ID,
            SHARES_NAME,
            SHARE_TYPE_CODE_ID,
            SHARE_TYPE_CODE_VALUE,
            USER_ID,
            IS_INTRADAY
        }

        public enum enmSharesTrackerBuy
        {
            SHARES_TRACKER_BUY_ID,
            SHARES_TRACKER_HEADER_ID,
            SHARES_PRICE_AMT,
            SHARES_QUANTITY,
            SHARES_BUY_DATE,
            SHARES_CHARGES_AMT
        }

        public enum enmSharesTrackerSell
        {
            SHARES_TRACKER_SELL_ID,
            SHARES_TRACKER_HEADER_ID,
            SHARES_PRICE_AMT,
            SHARES_QUANTITY,
            SHARES_SELL_DATE,
            SHARES_CHARGES_AMT
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
