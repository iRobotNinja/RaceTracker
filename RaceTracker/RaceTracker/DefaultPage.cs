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
        TextBox[] teamNumber;
        TextBox[] teamName;
        // Label[] teamSelHeaders = new Label[5];
        int totalTeams;
        
        


        public DefaultPage()
        {
            InitializeComponent();

            // set up header labels for 


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
                StopButton.Enabled = true;
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

            // data.Columns.Add("X");
            data.Columns.Add("TeamNumber");
            data.Columns.Add("TeamName");

            for (int i = 0; i < totalTeams; i++)
            {
                DataRow dataRow = data.NewRow();
                dataRow["TeamNumber"] = teamNumber[i].Text;
                dataRow["TeamName"] = teamName[i].Text;
                data.Rows.Add(dataRow);
            }


            string[] colNames = data.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();


            sb.AppendLine(string.Join(",", colNames));


            foreach(DataRow row in data.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();

                sb.AppendLine(string.Join(",", fields));
            }


            System.IO.File.WriteAllText((DateTime.Now.ToString("MM-dd-yyyy__hh-mm-ss") + "_test.csv"), sb.ToString());



            debugSave.Enabled = false;
        }



        private void fileSaveInit(string[] teamNames, string[] teamNumbers)
        {

        }


        private void FileSaveTimer_Tick(object sender, EventArgs e)
        {

        }

        private void SelNumTeams_Click(object sender, EventArgs e)
        {

            SelNumTeams.Enabled = false;

            // initialize the team numbers and team names text boxes
            totalTeams = Convert.ToInt32(Math.Round(numTeams.Value, 0));
            teamNumber = new TextBox[totalTeams];
            teamName = new TextBox[totalTeams];


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
                this.Controls.Add(teamNumber[i]);
                teamNumber[i].Font = new Font(teamNumber[i].Font.FontFamily, 14);
                teamNumber[i].Left = 12;
                teamNumber[i].Top = i * 30 + 200;
                teamNumber[i].Width = 50;


                // team name text boxes
                teamName[i] = new TextBox();
                this.Controls.Add(teamName[i]);
                teamName[i].Font = new Font(teamName[i].Font.FontFamily, 14);
                teamName[i].Left = 80;
                teamName[i].Top = i * 30 + 200;


                //// add and remove lap buttons
                //teamNumber[i] = new TextBox();
                //this.Controls.Add(teamNumber[i]);
                //teamNumber[i].Font = new Font(teamNumber[i].Font.FontFamily, 14);
                //teamNumber[i].Left = 12;
                //teamNumber[i].Top = i * 30 + 200;

            }

        }

        private void TeamSelLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
