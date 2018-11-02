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

        /**
         * In the file:
         *      'L' = Lap
         *      'R' = Remove Lap
         *      'T' = Time Event - File auto save
         *      'P' = Pit Start
         * 
         **/
        private String filepath = (DateTime.Now.ToString("MM-dd-yyyy__hh-mm-ss") + "_test.csv");
        private const int timerInterval = 10;
        private const int FileTimerInverval = 5 * 1000; // Seconds * milis
        private Stopwatch stopWatch = new Stopwatch();
        private DataTable data = new DataTable();
        TextBox[] teamNumber;
        TextBox[] teamName;
        Button[] addLap;
        Button[] removeLap;
        int totalTeams;
        
        


        public DefaultPage()
        {
            InitializeComponent();
            data.Columns.Add("TeamNumber");
            data.Columns.Add("Event");
            data.Columns.Add("Time");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            RaceTime.Text = String.Format("{0}:{1:D2}:{2:D2}:{3:D2}", 
                (int)stopWatch.Elapsed.TotalHours, 
                stopWatch.Elapsed.Minutes, 
                stopWatch.Elapsed.Seconds, 
                stopWatch.Elapsed.Milliseconds);

            RaceTimeRemain.Text = String.Format("{0}:{1:D2}:{2:D2}:{3:D2}",
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
                StopButton.Enabled = true;

                FileSaveTimer.Start();
                FileSaveTimer.Interval = FileTimerInverval;
            }
        }
        
        // stop button
        private void StopButton_Click(object sender, EventArgs e)
        {
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
            }
        }

        private void debugSave_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();

            // test setup data table
            //data.Columns.Add("DefTeamNumber");
            //data.Columns.Add("DefTeamName");
            //data.Columns.Add("AveragePitTime");
            //data.Columns.Add("AverageLapTime");
            //data.Columns.Add(" ");
            //data.Columns.Add("  ");
            data.Columns.Add("TeamNumber");
            data.Columns.Add("Event");
            data.Columns.Add("Time");


            string[] colNames = data.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();


            sb.AppendLine(string.Join(",", colNames));


            foreach(DataRow row in data.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();

                sb.AppendLine(string.Join(",", fields));
            }


            System.IO.File.WriteAllText((filepath), sb.ToString());



            debugSave.Enabled = false;
        }



        private void fileSaveInit(string[] teamNames, string[] teamNumbers)
        {

        }


        private void FileSaveTimer_Tick(object sender, EventArgs e)
        {
            writeTimeEvent(-1, 'T');
        }

        private void SelNumTeams_Click(object sender, EventArgs e)
        {

            SelNumTeams.Enabled = false;

            // initialize the team numbers and team names text boxes
            totalTeams = Convert.ToInt32(Math.Round(numTeams.Value, 0));
            teamNumber = new TextBox[totalTeams];
            teamName = new TextBox[totalTeams];
            addLap = new Button[totalTeams];
            removeLap = new Button[totalTeams];
            


            // sets up team # label. -- MIGRATE TO BE PRESENT BY DEFAULT

            Label teamNumLabel = new Label();
            teamNumLabel.Text = "Team #";
            teamNumLabel.Left = 12;
            teamNumLabel.Top = 175;
            this.Controls.Add(teamNumLabel);

            for (int i = 0; i < totalTeams; i++)
            {
                // team number text boxes
                teamNumber[i] = new TextBox();
                Cars.Controls.Add(teamNumber[i]);
                teamNumber[i].Font = new Font(teamNumber[i].Font.FontFamily, 14);
                teamNumber[i].Left = 12;
                teamNumber[i].Top = i * 30 + 200;
                teamNumber[i].Width = 50;


                // team name text boxes
                teamName[i] = new TextBox();
                Cars.Controls.Add(teamName[i]);
                teamName[i].Font = new Font(teamName[i].Font.FontFamily, 14);
                teamName[i].Left = 80;
                teamName[i].Top = i * 30 + 200;


                // add lap buttons
                addLap[i] = new Button();
                addLap[i].Tag = i;
                addLap[i].Text = "Add Lap";
                addLap[i].Left = 200;
                addLap[i].Top = i * 30 + 200;

                addLap[i].Click += new System.EventHandler(addLapButtonClicked);
                Cars.Controls.Add(addLap[i]);

                // add lap buttons
                addLap[i] = new Button();
                addLap[i].Tag = i;
                addLap[i].Text = "Remove Lap";
                addLap[i].Left = 300;
                addLap[i].Top = i * 30 + 200;

                addLap[i].Click += new System.EventHandler(removeLapButtonClicked);
                Cars.Controls.Add(addLap[i]);

            }

        }

        public void addLapButtonClicked(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Button " + btn.Tag + " Pressed");

            writeTimeEvent(Convert.ToInt32(btn.Tag.ToString()), 'L');
        }

        public void removeLapButtonClicked(object sender, System.EventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("Button " + btn.Tag + " Pressed");

            writeTimeEvent(Convert.ToInt32(btn.Tag.ToString()), 'R');
        }

        public void writeTimeEvent(int teamNumIndex, Char theEvent)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < totalTeams; i++)
            {
                DataRow dataRow = data.NewRow();
                dataRow["TeamNumber"] = (teamNumIndex != -1) ? teamNumber[teamNumIndex].Text : (-1).ToString();
                dataRow["Event"] = theEvent; // Remove Lap
                dataRow["Time"] = RaceTime.Text;
                data.Rows.Add(dataRow);
            }

            string[] colNames = data.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();


            sb.AppendLine(string.Join(",", colNames));
            foreach (DataRow row in data.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();

                sb.AppendLine(string.Join(",", fields));
            }

            System.IO.File.WriteAllText((filepath), sb.ToString());
        }

        private void TeamSelLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openLapData_Click(object sender, EventArgs e)
        {
            LapDataPage lapData = new LapDataPage();
            lapData.Show();
        }
    }
}
