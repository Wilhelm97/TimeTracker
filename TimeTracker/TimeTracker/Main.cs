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
        public TimeSpan D { get; private set; }

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
            textBox4.Clear();
            textBox4.Text += duration;
            D = duration;
            int Hours = (int)D.TotalHours;
            int Min = (int)D.TotalMinutes;

            if (CbCharge.SelectedItem != null)
            {
                int x = int.Parse(CbCharge.SelectedItem.ToString());
                textBox5.Text += (Hours + 1) * x;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            string root = "C:\\Users\\Owner\\Documents\\TimeTracker";

            string subdir = "C:\\Users\\Owner\\Documents\\TimeTracker\\Testing";

            // If directory does not exist, create it.

            if (!Directory.Exists(root))
            {

                Directory.CreateDirectory(root);

            }

            SaveFileDialog saveFileDialog1 = new SaveFileDialog();

            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    System.IO.StreamWriter sw = new System.IO.StreamWriter(saveFileDialog1.FileName.ToString());
                    sw.WriteLine("Date: " + textBox3.Text);
                    sw.WriteLine("Time Started: " + textBox1.Text);
                    sw.WriteLine("Time Ended: " + textBox2.Text);
                    sw.WriteLine("Time Worked: " + textBox4.Text);
                    sw.WriteLine("Amount Charged: " + textBox5.Text);
                    sw.WriteLine("Comments: " + textBox6.Text);
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

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void CbCharge_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
