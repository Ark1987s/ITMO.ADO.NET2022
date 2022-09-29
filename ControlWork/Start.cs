using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }
        public bool LoginSuccess = false;

        private void startbutton_Click(object sender, EventArgs e)
        {
            string connString = $"Data Source=.\\SQLEXPRESS;Initial Catalog=ApressFinancial;Persist Security Info=True;User ID={loginBox.Text};Password={pwBox.Text}";             
            using (SqlConnection cn = new SqlConnection(connString))
            {
                try
                {
                    cn.Open();
                    LoginSuccess = true;
                    Data.login = loginBox.Text;
                    Data.password = pwBox.Text;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Not connected, error: {ex.Message}");
                }
            }
            Close();
        }
    }
    static class Data
    {
        public static string login, password;
    }
}
