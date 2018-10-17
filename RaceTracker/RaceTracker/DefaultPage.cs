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




namespace RaceTracker
{
    public partial class DefaultPage : Form
    {

        private const int timerInterval = 10;
        private Stopwatch stopWatch = new Stopwatch();
        private DataTable data = new DataTable(); 

        // test setup datatable
        

        public DefaultPage()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RaceTime.Text = String.Format("{0}:{1:D2}:{2:D2}:{3:D2}", 
                (int)stopWatch.Elapsed.TotalHours, 
                stopWatch.Elapsed.Minutes, 
                stopWatch.Elapsed.Seconds, 
                stopWatch.Elapsed.Milliseconds);

            RaceTime.Text = String.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
                (int)stopWatch.Elapsed.TotalHours,
                stopWatch.Elapsed.Minutes,
                stopWatch.Elapsed.Seconds,
                stopWatch.Elapsed.Milliseconds);


        }

        // start button
        private void button1_Click(object sender, EventArgs e)
        {
            if (!stopWatch.IsRunning)
            {
                timer1.Start();
                timer1.Interval = timerInterval;
                stopWatch.Start();
                StopButton.Visible = true;
            }
        }
        
        // stop button
        private void StopButton_Click(object sender, EventArgs e)
        {
            if(stopWatch.IsRunning)
                stopWatch.Stop();
        }

        private void debugSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // test setup data table


            data.Columns.Add("column1");
            data.Rows.Add("row1");



            string[] colNames = 
        }
    }
}
