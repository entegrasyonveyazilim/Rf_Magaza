using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace KoctasMobil
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [MTAThread]
        static void Main()
        {
            Application.Run(new AK_Login());              
        }
        public static bool canli = false;
        public static bool adresleme = true;
        
    }
}