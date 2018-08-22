using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimeTracker
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            String startTime = DateTime.Now.ToString("h:mm tt");
            textBox1.Clear();
            textBox1.Text += startTime;
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
            String endTime = DateTime.Now.ToString("h:mm tt");
            textBox2.Clear();
            textBox2.Text += endTime;
            TimeSpan duration = DateTime.Parse(textBox1.Text).Subtract(DateTime.Parse(textBox2.Text));
            textBox4.Text += duration;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                StreamWriter sw = new StreamWriter("C:\\Users\\Owner\\Documents\\TimeTrack.txt");
                sw.WriteLine(textBox1.Text);
                sw.WriteLine(textBox2.Text);
                sw.WriteLine(textBox3.Text);
                sw.WriteLine(textBox4.Text);
                sw.Close();
            }
            catch (Exception t)
            {
                Console.WriteLine("Exception: " + t.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
