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
    public partial class Form1 : Form
    {  
          
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = apressFinancialDataSet.Customers;
            sqlDataAdapter1.Fill(apressFinancialDataSet.Customers);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Adapter_RowUpdating(object sender, System.Data.SqlClient.SqlRowUpdatingEventArgs e)
        {
            ApressFinancialDataSet.CustomersRow CustRow = (ApressFinancialDataSet.CustomersRow)e.Row;
            DialogResult response = MessageBox.Show("Continue updating " + CustRow.CustomerId.ToString() + "?", "Continue Update?", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                e.Status = UpdateStatus.SkipCurrentRow;
            }
        }
        private void Adapter_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {
            ApressFinancialDataSet.CustomersRow CustRow = (ApressFinancialDataSet.CustomersRow)e.Row;
            MessageBox.Show(CustRow.CustomerId.ToString() + " has been updated");
            apressFinancialDataSet.Customers.Clear();
            sqlDataAdapter1.Fill(apressFinancialDataSet);
        }
        private void adapter_FillError(object sender, FillErrorEventArgs e)
        {
            DialogResult response = MessageBox.Show("The following error occurred while Filling the DataSet: "
                + e.Errors.Message.ToString() + " Continue attempting to fill?", "FillError Encountered", MessageBoxButtons.YesNo);
            if (response == DialogResult.Yes)
            {
                e.Continue = true;
            }
            else
            {
                e.Continue = false;
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
            {
                dataGridView1.Rows.Remove(row);
            }
        }
        private void Save_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Update(apressFinancialDataSet);
        }
    }
}
