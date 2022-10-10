using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlWork
{    
    public partial class Main : Form
    {    
        private SqlConnection ApressFinancialConn = new SqlConnection($"Data Source=.\\SQLEXPRESS;Initial Catalog=ApressFinancial;Persist Security Info=True;User ID={Data.login};Password={Data.password}");
        public Main()
        {           
            InitializeComponent();                     
        }
        private SqlDataAdapter SqlDataAdapterAF;
        private DataSet AFDataset = new DataSet("ApressFinancial");
        private DataTable CustomersTable = new DataTable("Customers");


        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapterAF = new SqlDataAdapter("SELECT * FROM [ApressFinancial].[CustomerDetails].[Customers]", ApressFinancialConn);
            AFDataset.Tables.Add(CustomersTable);
            SqlDataAdapterAF.Fill(AFDataset.Tables["Customers"]);
            dataGridView1.DataSource = AFDataset.Tables["Customers"];
            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapterAF);
        }



        private void delete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            AFDataset.EndInit();
            SqlDataAdapterAF.Update(AFDataset.Tables["Customers"]);
        }
    }
}
