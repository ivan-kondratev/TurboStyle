using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace TurboStyle
{
    static class Program
    {
        public static string connectionString = "server=localhost; user id=root;database=turbostyle; password=root";
        public static MySqlConnection cn = new MySqlConnection(connectionString);
        public static MySqlCommand cmd;
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }
    }
}
