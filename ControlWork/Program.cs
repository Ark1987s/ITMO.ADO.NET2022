using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);         
            Start login = new Start();
            Application.Run(login);
            if (login.LoginSuccess)
            {
                Main fMain = new Main();
                Application.Run(fMain);
            }
            else
            {
                MessageBox.Show("Ошибка доступа к MS SQL Server!");
            }
        }
    }        
}
