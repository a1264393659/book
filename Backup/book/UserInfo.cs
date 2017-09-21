using System;
using System.Collections.Generic;
using System.Text;

namespace book
{
    static class UserInfo
    {
        private static string user;
        private static string power;
        public static string UserID
        {
            get
            {
                return user;
            }
            set
            {
                user = value;
            }
        }
        public static string UserPower
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }
    }
}
