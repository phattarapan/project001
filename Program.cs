using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project001
{
    
    public class ForPrint
    {
        
        public string product_name { get; set; }
        public string price { get; set; }

        public string id { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public string amount { get; set; }

    }

    static class Program
    {
        public static string product_name { get; internal set; }
        public static string price { get; internal set; }

        public static string id { get; internal set; }
        public static string type { get; internal set; }
        public static string name { get; internal set; }
        public static string amount { get; internal set; }

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new login());
        }
        
    }
    
}
