namespace RaceTracker
{
    partial class DefaultPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }




        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StartButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.RaceTime = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RaceTimeRemain = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.debugSave = new System.Windows.Forms.Button();
            this.FileSaveTimer = new System.Windows.Forms.Timer(this.components);
            this.numTeams = new System.Windows.Forms.NumericUpDown();
            this.SelNumTeams = new System.Windows.Forms.Button();
            this.TeamSelLayout = new System.Windows.Forms.TableLayoutPanel();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Tabs = new System.Windows.Forms.TabControl();
            this.Cars = new System.Windows.Forms.TabPage();
            this.LapDataTab = new System.Windows.Forms.TabPage();
            this.LogTab = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.openLapData = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numTeams)).BeginInit();
            this.TeamSelLayout.SuspendLayout();
            this.Tabs.SuspendLayout();
            this.Cars.SuspendLayout();
            this.LapDataTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StartButton
            // 
            this.StartButton.Location = new System.Drawing.Point(5, 72);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 23);
            this.StartButton.TabIndex = 1;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = true;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(89, 72);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(75, 23);
            this.StopButton.TabIndex = 2;
            this.StopButton.Text = "Stop";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // RaceTime
            // 
            this.RaceTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTime.Location = new System.Drawing.Point(5, 22);
            this.RaceTime.Name = "RaceTime";
            this.RaceTime.Size = new System.Drawing.Size(159, 40);
            this.RaceTime.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Total Race Time\r\n";
            // 
            // RaceTimeRemain
            // 
            this.RaceTimeRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RaceTimeRemain.Location = new System.Drawing.Point(190, 22);
            this.RaceTimeRemain.Name = "RaceTimeRemain";
            this.RaceTimeRemain.Size = new System.Drawing.Size(159, 40);
            this.RaceTimeRemain.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Time Remaining";
            // 
            // debugSave
            // 
            this.debugSave.Location = new System.Drawing.Point(698, 407);
            this.debugSave.Name = "debugSave";
            this.debugSave.Size = new System.Drawing.Size(75, 23);
            this.debugSave.TabIndex = 7;
            this.debugSave.Text = "Save to file";
            this.debugSave.UseVisualStyleBackColor = true;
            this.debugSave.Visible = false;
            this.debugSave.Click += new System.EventHandler(this.debugSave_Click);
            // 
            // FileSaveTimer
            // 
            this.FileSaveTimer.Tick += new System.EventHandler(this.FileSaveTimer_Tick);
            // 
            // numTeams
            // 
            this.numTeams.Location = new System.Drawing.Point(5, 127);
            this.numTeams.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numTeams.Name = "numTeams";
            this.numTeams.Size = new System.Drawing.Size(120, 20);
            this.numTeams.TabIndex = 8;
            // 
            // SelNumTeams
            // 
            this.SelNumTeams.Location = new System.Drawing.Point(131, 127);
            this.SelNumTeams.Name = "SelNumTeams";
            this.SelNumTeams.Size = new System.Drawing.Size(75, 23);
            this.SelNumTeams.TabIndex = 9;
            this.SelNumTeams.Text = "button1";
            this.SelNumTeams.UseVisualStyleBackColor = true;
            this.SelNumTeams.Click += new System.EventHandler(this.SelNumTeams_Click);
            // 
            // TeamSelLayout
            // 
            this.TeamSelLayout.ColumnCount = 8;
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TeamSelLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TeamSelLayout.Controls.Add(this.textBox4, 0, 1);
            this.TeamSelLayout.Controls.Add(this.textBox5, 1, 1);
            this.TeamSelLayout.Controls.Add(this.textBox2, 0, 2);
            this.TeamSelLayout.Controls.Add(this.textBox3, 1, 2);
            this.TeamSelLayout.Controls.Add(this.label4, 1, 0);
            this.TeamSelLayout.Controls.Add(this.textBox6, 0, 3);
            this.TeamSelLayout.Controls.Add(this.textBox7, 0, 4);
            this.TeamSelLayout.Controls.Add(this.textBox8, 0, 5);
            this.TeamSelLayout.Controls.Add(this.textBox9, 0, 6);
            this.TeamSelLayout.Controls.Add(this.textBox10, 0, 7);
            this.TeamSelLayout.Controls.Add(this.textBox11, 0, 8);
            this.TeamSelLayout.Controls.Add(this.textBox12, 0, 9);
            this.TeamSelLayout.Controls.Add(this.textBox13, 1, 3);
            this.TeamSelLayout.Controls.Add(this.textBox14, 1, 5);
            this.TeamSelLayout.Controls.Add(this.textBox15, 1, 4);
            this.TeamSelLayout.Controls.Add(this.textBox16, 1, 6);
            this.TeamSelLayout.Controls.Add(this.textBox17, 1, 7);
            this.TeamSelLayout.Controls.Add(this.textBox18, 1, 8);
            this.TeamSelLayout.Controls.Add(this.textBox19, 1, 9);
            this.TeamSelLayout.Controls.Add(this.button1, 5, 1);
            this.TeamSelLayout.Controls.Add(this.button2, 6, 1);
            this.TeamSelLayout.Controls.Add(this.button3, 5, 2);
            this.TeamSelLayout.Controls.Add(this.button4, 5, 3);
            this.TeamSelLayout.Controls.Add(this.button5, 5, 4);
            this.TeamSelLayout.Controls.Add(this.button6, 5, 5);
            this.TeamSelLayout.Controls.Add(this.button7, 5, 6);
            this.TeamSelLayout.Controls.Add(this.button8, 5, 7);
            this.TeamSelLayout.Controls.Add(this.button9, 5, 8);
            this.TeamSelLayout.Controls.Add(this.button10, 5, 9);
            this.TeamSelLayout.Controls.Add(this.button11, 6, 2);
            this.TeamSelLayout.Controls.Add(this.button12, 6, 3);
            this.TeamSelLayout.Controls.Add(this.button13, 6, 4);
            this.TeamSelLayout.Controls.Add(this.button14, 6, 5);
            this.TeamSelLayout.Controls.Add(this.button15, 6, 6);
            this.TeamSelLayout.Controls.Add(this.button16, 6, 7);
            this.TeamSelLayout.Controls.Add(this.button17, 6, 8);
            this.TeamSelLayout.Controls.Add(this.button18, 6, 9);
            this.TeamSelLayout.Controls.Add(this.button19, 7, 1);
            this.TeamSelLayout.Controls.Add(this.button20, 7, 2);
            this.TeamSelLayout.Controls.Add(this.button21, 7, 3);
            this.TeamSelLayout.Controls.Add(this.button22, 7, 4);
            this.TeamSelLayout.Controls.Add(this.button23, 7, 5);
            this.TeamSelLayout.Controls.Add(this.button24, 7, 6);
            this.TeamSelLayout.Controls.Add(this.button25, 7, 7);
            this.TeamSelLayout.Controls.Add(this.button26, 7, 8);
            this.TeamSelLayout.Controls.Add(this.button27, 7, 9);
            this.TeamSelLayout.Controls.Add(this.label3, 0, 0);
            this.TeamSelLayout.Location = new System.Drawing.Point(433, 26);
            this.TeamSelLayout.Name = "TeamSelLayout";
            this.TeamSelLayout.RowCount = 10;
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TeamSelLayout.Size = new System.Drawing.Size(340, 287);
            this.TeamSelLayout.TabIndex = 10;
            this.TeamSelLayout.Visible = false;
            this.TeamSelLayout.Paint += new System.Windows.Forms.PaintEventHandler(this.TeamSelLayout_Paint);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(3, 27);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(109, 27);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(3, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(109, 56);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(109, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "Name";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(3, 85);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(3, 114);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 20);
            this.textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(3, 143);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 20);
            this.textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(3, 172);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 20);
            this.textBox9.TabIndex = 9;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(3, 201);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(100, 20);
            this.textBox10.TabIndex = 10;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(3, 230);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 20);
            this.textBox11.TabIndex = 11;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(3, 259);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(100, 20);
            this.textBox12.TabIndex = 12;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(109, 85);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(100, 20);
            this.textBox13.TabIndex = 13;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(109, 143);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(100, 20);
            this.textBox14.TabIndex = 14;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(109, 114);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(100, 20);
            this.textBox15.TabIndex = 15;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(109, 172);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(100, 20);
            this.textBox16.TabIndex = 16;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(109, 201);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(100, 20);
            this.textBox17.TabIndex = 17;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(109, 230);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(100, 20);
            this.textBox18.TabIndex = 18;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(109, 259);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(100, 20);
            this.textBox19.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(215, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(36, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "+1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(257, 27);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "-1";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(215, 56);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(36, 23);
            this.button3.TabIndex = 22;
            this.button3.Text = "+1";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(215, 85);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(36, 23);
            this.button4.TabIndex = 23;
            this.button4.Text = "+1";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(215, 114);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(36, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "+1";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(215, 143);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(36, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "+1";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(215, 172);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(36, 23);
            this.button7.TabIndex = 26;
            this.button7.Text = "+1";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(215, 201);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(36, 23);
            this.button8.TabIndex = 27;
            this.button8.Text = "+1";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(215, 230);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(36, 23);
            this.button9.TabIndex = 28;
            this.button9.Text = "+1";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(215, 259);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(36, 23);
            this.button10.TabIndex = 29;
            this.button10.Text = "+1";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(257, 56);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(36, 23);
            this.button11.TabIndex = 30;
            this.button11.Text = "-1";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(257, 85);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(36, 23);
            this.button12.TabIndex = 31;
            this.button12.Text = "-1";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(257, 114);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(36, 23);
            this.button13.TabIndex = 32;
            this.button13.Text = "-1";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(257, 143);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 23);
            this.button14.TabIndex = 33;
            this.button14.Text = "-1";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(257, 172);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(36, 23);
            this.button15.TabIndex = 34;
            this.button15.Text = "-1";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(257, 201);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(36, 23);
            this.button16.TabIndex = 35;
            this.button16.Text = "-1";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(257, 230);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(36, 23);
            this.button17.TabIndex = 36;
            this.button17.Text = "-1";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(257, 259);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(36, 23);
            this.button18.TabIndex = 37;
            this.button18.Text = "-1";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(299, 27);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(38, 23);
            this.button19.TabIndex = 38;
            this.button19.Text = "PIT";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(299, 56);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(38, 23);
            this.button20.TabIndex = 39;
            this.button20.Text = "PIT";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(299, 85);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(38, 23);
            this.button21.TabIndex = 40;
            this.button21.Text = "PIT";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(299, 114);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(38, 23);
            this.button22.TabIndex = 41;
            this.button22.Text = "PIT";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(299, 143);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(38, 23);
            this.button23.TabIndex = 42;
            this.button23.Text = "PIT";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(299, 172);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(38, 23);
            this.button24.TabIndex = 43;
            this.button24.Text = "PIT";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(299, 201);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(38, 23);
            this.button25.TabIndex = 44;
            this.button25.Text = "PIT";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(299, 230);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(38, 23);
            this.button26.TabIndex = 45;
            this.button26.Text = "PIT";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(299, 259);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(38, 23);
            this.button27.TabIndex = 46;
            this.button27.Text = "PIT";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Number";
            // 
            // Tabs
            // 
            this.Tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Tabs.Controls.Add(this.Cars);
            this.Tabs.Controls.Add(this.LogTab);
            this.Tabs.Controls.Add(this.LapDataTab);
            this.Tabs.Controls.Add(this.tabPage3);
            this.Tabs.Location = new System.Drawing.Point(0, 0);
            this.Tabs.Name = "Tabs";
            this.Tabs.SelectedIndex = 0;
            this.Tabs.Size = new System.Drawing.Size(805, 458);
            this.Tabs.TabIndex = 11;
            this.Tabs.TabStop = false;
            // 
            // Cars
            // 
            this.Cars.Controls.Add(this.label1);
            this.Cars.Controls.Add(this.StartButton);
            this.Cars.Controls.Add(this.SelNumTeams);
            this.Cars.Controls.Add(this.StopButton);
            this.Cars.Controls.Add(this.numTeams);
            this.Cars.Controls.Add(this.RaceTime);
            this.Cars.Controls.Add(this.RaceTimeRemain);
            this.Cars.Controls.Add(this.label2);
            this.Cars.Location = new System.Drawing.Point(4, 22);
            this.Cars.Name = "Cars";
            this.Cars.Padding = new System.Windows.Forms.Padding(3);
            this.Cars.Size = new System.Drawing.Size(797, 432);
            this.Cars.TabIndex = 0;
            this.Cars.Text = "Cars";
            this.Cars.UseVisualStyleBackColor = true;
            // 
            // LapDataTab
            // 
            this.LapDataTab.Controls.Add(this.openLapData);
            this.LapDataTab.Location = new System.Drawing.Point(4, 22);
            this.LapDataTab.Name = "LapDataTab";
            this.LapDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.LapDataTab.Size = new System.Drawing.Size(797, 432);
            this.LapDataTab.TabIndex = 1;
            this.LapDataTab.Text = "Lap Data";
            this.LapDataTab.UseVisualStyleBackColor = true;
            // 
            // LogTab
            // 
            this.LogTab.Location = new System.Drawing.Point(4, 22);
            this.LogTab.Name = "LogTab";
            this.LogTab.Size = new System.Drawing.Size(797, 432);
            this.LogTab.TabIndex = 2;
            this.LogTab.Text = "Log";
            this.LogTab.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(797, 432);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // openLapData
            // 
            this.openLapData.Location = new System.Drawing.Point(243, 147);
            this.openLapData.Name = "openLapData";
            this.openLapData.Size = new System.Drawing.Size(356, 97);
            this.openLapData.TabIndex = 0;
            this.openLapData.Text = "Compute and Open Lap Data";
            this.openLapData.UseVisualStyleBackColor = true;
            this.openLapData.Click += new System.EventHandler(this.openLapData_Click);
            // 
            // DefaultPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tabs);
            this.Controls.Add(this.TeamSelLayout);
            this.Controls.Add(this.debugSave);
            this.Name = "DefaultPage";
            this.Text = "RIOT Racing Race Timer";
            ((System.ComponentModel.ISupportInitialize)(this.numTeams)).EndInit();
            this.TeamSelLayout.ResumeLayout(false);
            this.TeamSelLayout.PerformLayout();
            this.Tabs.ResumeLayout(false);
            this.Cars.ResumeLayout(false);
            this.Cars.PerformLayout();
            this.LapDataTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.TextBox RaceTime;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox RaceTimeRemain;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button debugSave;
        private System.Windows.Forms.Timer FileSaveTimer;
        private System.Windows.Forms.NumericUpDown numTeams;
        private System.Windows.Forms.Button SelNumTeams;
        private System.Windows.Forms.TableLayoutPanel TeamSelLayout;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.TextBox textBox18;
        private System.Windows.Forms.TextBox textBox19;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.TabControl Tabs;
        private System.Windows.Forms.TabPage Cars;
        private System.Windows.Forms.TabPage LapDataTab;
        private System.Windows.Forms.TabPage LogTab;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button openLapData;
    }
}