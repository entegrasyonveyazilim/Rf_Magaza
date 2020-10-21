using System;
using System.Collections.Generic;
using System.Text;

namespace KoctasMobil
{
    class ProgramGlobalData
    {
        public static System.Net.NetworkCredential g_credential;
        public static string username;
        public static string loginWerks;
        public static string loginMagnet;

        public static string modUser = "mod";
        public static string modPass = "9123";
        public static bool guvenliMod = false;
        public static string sunucuTip = "PROD";
        public static string sunucuIp;

        static string _ImzaTeFileName = "urun_tutanak_1";
        public static string ImzaTeFileName
        {
            get { return ProgramGlobalData._ImzaTeFileName; }
            set { ProgramGlobalData._ImzaTeFileName = value; }
        }

        static string _ImzaTaFileName = "urun_tutanak_2";
        public static string ImzaTaFileName
        {
            get { return ProgramGlobalData._ImzaTaFileName; }
            set { ProgramGlobalData._ImzaTaFileName = value; }
        }

        static string _ImzaMyFileName = "urun_tutanak_3";
        public static string ImzaMyFileName
        {
            get { return ProgramGlobalData._ImzaMyFileName; }
            set { ProgramGlobalData._ImzaMyFileName = value; }
        }
    }
}
