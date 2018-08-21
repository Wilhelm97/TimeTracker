using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox1.Text += DateTime.Now.ToString("h:mm tt");
            textBox3.Clear();
            textBox3.Text += DateTime.Now.ToString("dddd, dd MMMM yyyy");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox2.Text += DateTime.Now.ToString("h:mm tt");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Owner\\Documents\\TimeTracker.txt");
            sw.Write(textBox1.Text);
            sw.Write("\n");
            sw.Write(textBox2.Text);
            sw.Write(monthCalendar1);
            sw.Close();

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
