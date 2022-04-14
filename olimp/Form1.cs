using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;

namespace olimp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.Rows.Add(1, 2);
            dataGridView1.Rows.Add(2, 3);
            dataGridView1.Rows.Add(3, 4);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.Columns[0].HeaderCell.Style.BackColor = Color.DarkGray;
            dataGridView1.Rows.Add(1, 2);
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
    }
}
