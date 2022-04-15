using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
            
        }
        
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
            int a=0;
            for (int i = 0; i < listBox1.Items.Count; i++)
                if ('('+comboBox1.SelectedItem.ToString()+')' + " - " + '('+comboBox2.SelectedItem.ToString()+')' == listBox1.Items[i].ToString())
                    a = 1;
            if (a != 1)
                listBox1.Items.Add('(' + comboBox1.SelectedItem.ToString() + ')' + " - " + '(' + comboBox2.SelectedItem.ToString() + ')');
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы уверены?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
                listBox1.Items.Remove(listBox1.SelectedIndex);
        }
    }
}
