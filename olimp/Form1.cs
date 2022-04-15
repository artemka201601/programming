using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp3;
using System.Text.RegularExpressions;
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
        Regex regex_xy = new Regex(@"^[1-9]{1}[0-9]?[0-9]?[0-9]?$");

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
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "")
            {
                button5.Enabled = false;
                button7.Enabled = false;
            }
            else
            {
                button5.Enabled = true;
                button7.Enabled = true;
            }
            if (textBox7.Text == "" || textBox8.Text == "" || textBox9.Text == "" || comboBox1.Text == "")
            {
                button4.Enabled = false;
            }
            else
            {
                button4.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
        }


        private void groupBox1_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Gray);
        }


        private void DrawGroupBox(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush, 2);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, rect.X + 120, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left + 120, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width)+ 120, rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox4_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox(box, e.Graphics, Color.Black, Color.Gray);
        }
        private void DrawGroupBox2(GroupBox box, Graphics g, Color textColor, Color borderColor)
        {
            if (box != null)
            {
                Brush textBrush = new SolidBrush(textColor);
                Brush borderBrush = new SolidBrush(borderColor);
                Pen borderPen = new Pen(borderBrush, 2);
                SizeF strSize = g.MeasureString(box.Text, box.Font);
                Rectangle rect = new Rectangle(box.ClientRectangle.X,
                                               box.ClientRectangle.Y + (int)(strSize.Height / 2),
                                               box.ClientRectangle.Width - 1,
                                               box.ClientRectangle.Height - (int)(strSize.Height / 2) - 1);

                // Clear text and border
                g.Clear(this.BackColor);

                // Draw text
                g.DrawString(box.Text, box.Font, textBrush, 0, 0);

                // Drawing Border
                //Left
                g.DrawLine(borderPen, rect.Location, new Point(rect.X, rect.Y + rect.Height));
                //Right
                g.DrawLine(borderPen, new Point(rect.X + rect.Width, rect.Y), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Bottom
                g.DrawLine(borderPen, new Point(rect.X, rect.Y + rect.Height), new Point(rect.X + rect.Width, rect.Y + rect.Height));
                //Top1
                g.DrawLine(borderPen, new Point(rect.X, rect.Y), new Point(rect.X + box.Padding.Left, rect.Y));
                //Top2
                g.DrawLine(borderPen, new Point(rect.X + box.Padding.Left + (int)(strSize.Width), rect.Y), new Point(rect.X + rect.Width, rect.Y));
            }
        }

        private void groupBox5_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox2(box, e.Graphics, Color.Black, Color.Gray);
        }


        private void groupBox3_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox2(box, e.Graphics, Color.Black, Color.Gray);
        }

        private void groupBox2_Paint(object sender, PaintEventArgs e)
        {
            GroupBox box = sender as GroupBox;
            DrawGroupBox2(box, e.Graphics, Color.Black, Color.Gray);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (!regex_xy.IsMatch(textBox1.Text))
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                }
                if (textBox1.Text.Length != 0)
                {
                    if (textBox2.Text.Length >= 4)
                    {
                        textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
                    }
                }
            }
            textBox1.SelectionStart = textBox1.Text.Length;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!regex_xy.IsMatch(textBox2.Text))
            {
                if (textBox2.Text.Length != 0)
                {
                    textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                }
                if (textBox2.Text.Length != 0)
                {
                    if (textBox2.Text.Length >= 4)
                    {
                        textBox2.Text = textBox2.Text.Remove(textBox2.Text.Length - 1);
                    }
                }
            }
            textBox2.SelectionStart = textBox2.Text.Length;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            if (!regex_xy.IsMatch(textBox7.Text))
            {
                if (textBox7.Text.Length != 0)
                {
                    textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
                }
                if (textBox7.Text.Length != 0)
                {
                    if (textBox7.Text.Length >= 4)
                    {
                        textBox7.Text = textBox7.Text.Remove(textBox7.Text.Length - 1);
                    }
                }
            }
            textBox7.SelectionStart = textBox7.Text.Length;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            if (!regex_xy.IsMatch(textBox8.Text))
            {
                if (textBox8.Text.Length != 0)
                {
                    textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
                }
                if (textBox8.Text.Length != 0)
                {
                    if (textBox8.Text.Length >= 4)
                    {
                        textBox8.Text = textBox8.Text.Remove(textBox8.Text.Length - 1);
                    }
                }
            }
            textBox8.SelectionStart = textBox8.Text.Length;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Решение невозможно","Результат");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                string query = $"INSERT INTO [table1] VALUES ({textBox1.Text}, {textBox2.Text}, '{comboBox1.SelectedItem}', {textBox9.Text})";
                OleDbCommand add = new OleDbCommand(query, connection);
                add.ExecuteNonQuery();
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
