using LawyersClient.Assets.View;
using LawyersClient.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LawyersClient
{
    internal static class Program
    {
        public static Welcome welcome;
        public static Home form;
        public static Insert formInsert;
        public static User user = new User();

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
 
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(welcome = new Welcome());
        }
    }
}
