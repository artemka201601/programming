using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace olimp
{
    public partial class Form1 : Form
    {
        private OleDbConnection myconnection;
        public string connString = "Provider = Microsoft.Jet.OLEDB.4.0; Data Source = D:\\VS PROJECTS\\olimp\\olimp.mdb";


        public Form1()
        {
            InitializeComponent();
            myconnection = new OleDbConnection(connString);
            myconnection.Open();
            try
            {
                OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter("SELECT * FROM [table1]", myconnection);
                DataTable data = new DataTable();
                dbDataAdapter.Fill(data);
                dataGridView1.DataSource = data;
                myconnection.Close();
            }
            catch
            {
                return;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkGray;
        }
    }
}
