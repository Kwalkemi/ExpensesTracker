using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpensesTracker.BusinessObject
{
    public static class Constant
    {
        public abstract class Common
        {
            public const string DATABASE_NAME = "Expenses_Tracker";
            public const string ENTITY_NAME = "Entity.xml";
            public const string XML = "\\Xml";
            public const string SPECIAL_CHARACTER_AT_THE_RATE = "@";
            public const string DOT_COM = ".com";
            public const string CATEGORY_ADD_BOX = "Category Add Box";
            public const string CATEGORY_REMOVE_BOX = "Category Remove Box";

            public abstract class Gender
            {
                public const string MALE = "Male";
                public const string FEMALE = "Female";
            }

            public abstract class CodeId
            {
                public const string CODE_ID_1 = "1";
                public const string CODE_ID_2 = "2";
                public const string CODE_ID_3 = "3";
                public const string CODE_ID_4 = "4";
                public const string CODE_ID_5 = "5";
                public const string CODE_ID_6 = "6";
            }

            public abstract class Bit_Value
            {
                public const string BIT_0 = "0";
                public const string BIT_1 = "1";
            }
        }

        public abstract class Table_Category_Value
        {
            public const string HUSBAND_WIFE_CATEGORY = "HUWF";
            public const string EXPENSES_TRACKER_CATEGORY = "EXPN";
        }

        public abstract class Query
        {
            public const string GET_USER_INFO = "GetUserInfo";
            public const string GET_USER_INFO_BY_ID = "GetUserInfoById";
            public const string UPDATE_REMEMBER_ME_CODE_VALUE = "UpdateRememberMeCodeValue";
            public const string GET_UPDATE_REMEMBER_CODE_VALUE = "GetUpdateRememberCodeValue";
            public const string LOAD_CATEGORY = "LoadCategory";
            public const string GET_EXPENSES_CATEGORY_ID_BY_NAME = "GetExpensesCategoryIdByName";
            public const string DELETE_EXPENSES_CATEGORY = "DeleteExpensesCategory";
            public const string LOAD_HUSBAND_WIFE_CHART = "LoadHusbandWifeChart";
            public const string LOG_OFF_QUERY = "LogoffQuery";
            public const string LOAD_EXPENSES_CHART = "LoadExpensesChart";
            public const string LOAD_EXPENSES_CHART_LIST = "LoadExpensesChartList";
            public const string UPDATE_SHARE_HEADER = "UpdateShareHeader";
        }

        public abstract class Error
        {
            public const string ERROR_1 = "Error_1";
            public const string ERROR_2 = "Error_2";
            public const string ERROR_3 = "Error_3";
            public const string ERROR_4 = "Error_4";
            public const string ERROR_5 = "Error_5";
            public const string ERROR_6 = "Error_6";
            public const string ERROR_7 = "Error_7";
            public const string ERROR_8 = "Error_8";
            public const string ERROR_9 = "Error_9";
            public const string ERROR_10 = "Error_10";
            public const string ERROR_11 = "Error_11";
            public const string ERROR_12 = "Error_12";
            public const string ERROR_13 = "Error_13";
            public const string ERROR_14 = "Error_14";
        }

        public abstract class Message
        {
            public const string REGISTRATION_SUCCESSFULY = "RegSuc";
            public const string HUSBAND_GIVE = "HusbandGive";
            public const string WIFE_EXTRA = "WifeExtra";
            public const string ALL_CLEAR = "AllClear";
        }

        public abstract class Husband_Wife
        {
            public abstract class Record_Type
            {
                public const string HUSBAND = "HUSB";
                public const string WIFE = "WIFE";
            }
        }

        public abstract class Expenses_Tracker
        {
            public abstract class Transaaction_Type
            {
                public const string INCOMING = "INCM";
                public const string OUTGOING = "OUTG";
            }

            public abstract class Transaaction_Type_Desc
            {
                public const string INCOMING = "Incoming";
                public const string OUTGOING = "Outgoing";
            }
        }

        public abstract class Shares_Tracker
        {
            public abstract class Shares_Type
            {
                public const string DELIVERY = "DELV";
                public const string OPTION = "OPTN";
            }

            public abstract class Profit_Loss
            {
                public const string PROFIT = "PROFIT";
                public const string LOSS = "LOSS";
            }

            public abstract class Buy_Sell
            {
                public const string BUY = "BUY";
                public const string SELL = "SELL";
            }
        }
    }
}
