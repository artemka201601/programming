using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace olimp
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }
        private Form1 MyForm = Application.OpenForms[0] as Form1;
        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = 0;
            for (int i = 0; i < listBox1.Items.Count; i++)
                if ('(' + comboBox1.SelectedItem.ToString() + ')' + " - " + '(' + comboBox2.SelectedItem.ToString() + ')' == listBox1.Items[i].ToString())
                    a = 1;
            if (a != 1)
            {
                listBox1.Items.Add('(' + comboBox1.SelectedItem.ToString() + ')' + " - " + '(' + comboBox2.SelectedItem.ToString() + ')');
                MyForm.listBox1.Items.Add('(' + comboBox1.SelectedItem.ToString() + ')' + " - " + '(' + comboBox2.SelectedItem.ToString() + ')');
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count && listBox1.SelectedIndex > -1)
            {
                MyForm.listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            }
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
        }
    }
}
