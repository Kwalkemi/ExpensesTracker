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
            public const string DATABASE_NAME_Temp = "Expenses_Tracker";
            public const string ENTITY_NAME = "Entity.xml";
            public const string XML = "\\Xml";
            public const string REGISTRATION_SUCCESSFULY = "RegSuc";
            public const string SPECIAL_CHARACTER_AT_THE_RATE = "@";
            public const string DOT_COM = ".com";

            public abstract class Gender
            {
                public const string Male = "Male";
                public const string Female = "Female";
            }

            public abstract class CodeId
            {
                public const string CODE_ID_1 = "1";
            }
        }

        public abstract class Query
        {
            public const string GET_USER_INFO = "GetUserInfo";
            public const string GET_USER_INFO_BY_ID = "GetUserInfoById";
            public const string UPDATE_REMEMBER_ME_CODE_VALUE = "UpdateRememberMeCodeValue";
            public const string GET_UPDATE_REMEMBER_CODE_VALUE = "GetUpdateRememberCodeValue";
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
        }
    }
}
