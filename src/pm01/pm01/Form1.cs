using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace pm01
{
    public partial class Form1 : Form
    {
        string f;
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                webBrowser1.Navigate("about:blank");
                f = Application.StartupPath + openFileDialog1;
                webBrowser1.Navigate(f);
                this.Size = new Size(1200, 800);
                webBrowser1.Visible = true;
                label1.Visible = true;
                label2.Visible = true;
                textBox1.Visible = true;
                textBox2.Visible = true;
                toolStripStatusLabel1.Visible = true;
            }


        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор работы: Тимофеев Максим Андреевич, ПКсп-118, 3 курс.");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);

            if ((y >= x * x) || (y <= -x * x) && (x >= y * y) || (x <= -y * y))
            {
                MessageBox.Show("Точка с введенными координатами принадлежит заштрихованной области");
                toolStripStatusLabel1.Text = "Точка входит";
            }
            else
            {
                MessageBox.Show("Точка не входит");
                toolStripStatusLabel1.Text = "Точка не входит";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
