using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace olimp
{
    public partial class Form1 : Form
    {
        public string connString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=olimp.mdb";
        OleDbConnection connection;
        public Form1()
        {
            InitializeComponent();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkGray;
            connection = new OleDbConnection(connString);
            connection.Open();
            try
            {
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter("SELECT * FROM [table1]", connection);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);
                dataGridView1.DataSource = dataTable;
                connection.Close();
            }
            catch
            {
                return;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                form.comboBox1.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString() + "," + dataGridView1.Rows[i].Cells[1].Value.ToString());
                form.comboBox2.Items.Add(dataGridView1.Rows[i].Cells[0].Value.ToString() + "," + dataGridView1.Rows[i].Cells[1].Value.ToString());

            }

            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                button5.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }
    }
}
