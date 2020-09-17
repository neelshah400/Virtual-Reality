using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsStopwatch
{
    public partial class Form1 : Form
    {

        Stopwatch stopwatch;
        bool displayInSeconds;

        public Form1()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
            displayInSeconds = radioSeconds.Checked;
        }

        private void radioSeconds_CheckedChanged(object sender, EventArgs e)
        {
            if (radioSeconds.Checked)
            {
                displayInSeconds = true;
                useSeconds();
            }
        }

        private void radioMilliseconds_CheckedChanged(object sender, EventArgs e)
        {
            if (radioMilliseconds.Checked)
            {
                displayInSeconds = false;
                useMilliseconds();
            }
        }

        private void buttonToggle_Click(object sender, EventArgs e)
        {
            if (stopwatch.IsRunning)
            {
                stopwatch.Stop();
                if (displayInSeconds)
                    useSeconds();
                else if (radioMilliseconds.Checked)
                    useMilliseconds();
                else
                    labelTime.Text = "ERROR!";
            }
            else
            {
                stopwatch.Start();
                labelTime.Text = "Counting...";
            }
        }

        private void labelTime_Click(object sender, EventArgs e)
        {

        }

        public void useSeconds()
        {
            if (!stopwatch.IsRunning)
                labelTime.Text = stopwatch.Elapsed.TotalSeconds + "";
        }

        public void useMilliseconds()
        {
            if (!stopwatch.IsRunning)
                labelTime.Text = stopwatch.Elapsed.TotalMilliseconds + "";
        }

    }
}
