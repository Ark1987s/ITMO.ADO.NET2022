﻿using System;
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
        public Main()
        {           
            InitializeComponent();
            sqlConnection1.ConnectionString = @"Data Source=.\SQLEXPRESS;Initial Catalog=ApressFinancial;Persist Security Info=True;User ID=UserB;Password=ultrAlongpw2485";
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = apressFinancialDataSet.Customers;
            sqlDataAdapter1.Fill(apressFinancialDataSet.Customers);
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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