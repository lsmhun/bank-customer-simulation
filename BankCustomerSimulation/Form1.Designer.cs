namespace BankCustomerSimulation
{
    partial class BankSimulationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BankSimulationForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.WaitingCustomerValue = new System.Windows.Forms.Label();
            this.WaitingCustomerLabel = new System.Windows.Forms.Label();
            this.CustomerPictBox5 = new System.Windows.Forms.PictureBox();
            this.CustomerPictBox4 = new System.Windows.Forms.PictureBox();
            this.CustomerPictBox3 = new System.Windows.Forms.PictureBox();
            this.CustomerPictBox2 = new System.Windows.Forms.PictureBox();
            this.CustomerPictBox1 = new System.Windows.Forms.PictureBox();
            this.EmpPictureBox3 = new System.Windows.Forms.PictureBox();
            this.EmpPictureBox2 = new System.Windows.Forms.PictureBox();
            this.EmpPictureBox1 = new System.Windows.Forms.PictureBox();
            this.AvgWaitingTimeValue = new System.Windows.Forms.Label();
            this.AvgWaitingTimeLabel = new System.Windows.Forms.Label();
            this.SumOfWaitingTimeValue = new System.Windows.Forms.Label();
            this.SumWaitingTimeLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.StartStopButton = new System.Windows.Forms.Button();
            this.EmloyeeNumberLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.CustomerNumberLabel = new System.Windows.Forms.Label();
            this.SettingsPanel = new System.Windows.Forms.Panel();
            this.CustomerTrackBar = new System.Windows.Forms.TrackBar();
            this.settingsManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DurationTrackBar = new System.Windows.Forms.TrackBar();
            this.EmployeeTrackBar = new System.Windows.Forms.TrackBar();
            this.GlobalTimer = new System.Windows.Forms.Timer(this.components);
            this.CustomerTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SettingsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.WaitingCustomerValue);
            this.panel2.Controls.Add(this.WaitingCustomerLabel);
            this.panel2.Controls.Add(this.CustomerPictBox5);
            this.panel2.Controls.Add(this.CustomerPictBox4);
            this.panel2.Controls.Add(this.CustomerPictBox3);
            this.panel2.Controls.Add(this.CustomerPictBox2);
            this.panel2.Controls.Add(this.CustomerPictBox1);
            this.panel2.Controls.Add(this.EmpPictureBox3);
            this.panel2.Controls.Add(this.EmpPictureBox2);
            this.panel2.Controls.Add(this.EmpPictureBox1);
            this.panel2.Controls.Add(this.AvgWaitingTimeValue);
            this.panel2.Controls.Add(this.AvgWaitingTimeLabel);
            this.panel2.Controls.Add(this.SumOfWaitingTimeValue);
            this.panel2.Controls.Add(this.SumWaitingTimeLabel);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(213, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 374);
            this.panel2.TabIndex = 1;
            // 
            // WaitingCustomerValue
            // 
            this.WaitingCustomerValue.AutoSize = true;
            this.WaitingCustomerValue.Location = new System.Drawing.Point(356, 291);
            this.WaitingCustomerValue.Name = "WaitingCustomerValue";
            this.WaitingCustomerValue.Size = new System.Drawing.Size(13, 13);
            this.WaitingCustomerValue.TabIndex = 14;
            this.WaitingCustomerValue.Text = "0";
            // 
            // WaitingCustomerLabel
            // 
            this.WaitingCustomerLabel.AutoSize = true;
            this.WaitingCustomerLabel.Location = new System.Drawing.Point(211, 291);
            this.WaitingCustomerLabel.Name = "WaitingCustomerLabel";
            this.WaitingCustomerLabel.Size = new System.Drawing.Size(130, 13);
            this.WaitingCustomerLabel.TabIndex = 13;
            this.WaitingCustomerLabel.Text = "Currently waiting customer";
            // 
            // CustomerPictBox5
            // 
            this.CustomerPictBox5.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPictBox5.Image")));
            this.CustomerPictBox5.Location = new System.Drawing.Point(25, 212);
            this.CustomerPictBox5.Name = "CustomerPictBox5";
            this.CustomerPictBox5.Size = new System.Drawing.Size(36, 50);
            this.CustomerPictBox5.TabIndex = 12;
            this.CustomerPictBox5.TabStop = false;
            this.CustomerPictBox5.Visible = false;
            // 
            // CustomerPictBox4
            // 
            this.CustomerPictBox4.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPictBox4.Image")));
            this.CustomerPictBox4.Location = new System.Drawing.Point(174, 212);
            this.CustomerPictBox4.Name = "CustomerPictBox4";
            this.CustomerPictBox4.Size = new System.Drawing.Size(36, 50);
            this.CustomerPictBox4.TabIndex = 11;
            this.CustomerPictBox4.TabStop = false;
            this.CustomerPictBox4.Visible = false;
            // 
            // CustomerPictBox3
            // 
            this.CustomerPictBox3.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPictBox3.Image")));
            this.CustomerPictBox3.Location = new System.Drawing.Point(121, 203);
            this.CustomerPictBox3.Name = "CustomerPictBox3";
            this.CustomerPictBox3.Size = new System.Drawing.Size(36, 50);
            this.CustomerPictBox3.TabIndex = 10;
            this.CustomerPictBox3.TabStop = false;
            this.CustomerPictBox3.Visible = false;
            // 
            // CustomerPictBox2
            // 
            this.CustomerPictBox2.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPictBox2.Image")));
            this.CustomerPictBox2.Location = new System.Drawing.Point(70, 173);
            this.CustomerPictBox2.Name = "CustomerPictBox2";
            this.CustomerPictBox2.Size = new System.Drawing.Size(36, 50);
            this.CustomerPictBox2.TabIndex = 9;
            this.CustomerPictBox2.TabStop = false;
            this.CustomerPictBox2.Visible = false;
            // 
            // CustomerPictBox1
            // 
            this.CustomerPictBox1.Image = ((System.Drawing.Image)(resources.GetObject("CustomerPictBox1.Image")));
            this.CustomerPictBox1.Location = new System.Drawing.Point(25, 145);
            this.CustomerPictBox1.Name = "CustomerPictBox1";
            this.CustomerPictBox1.Size = new System.Drawing.Size(36, 50);
            this.CustomerPictBox1.TabIndex = 8;
            this.CustomerPictBox1.TabStop = false;
            this.CustomerPictBox1.Visible = false;
            // 
            // EmpPictureBox3
            // 
            this.EmpPictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("EmpPictureBox3.Image")));
            this.EmpPictureBox3.Location = new System.Drawing.Point(279, 92);
            this.EmpPictureBox3.Name = "EmpPictureBox3";
            this.EmpPictureBox3.Size = new System.Drawing.Size(30, 50);
            this.EmpPictureBox3.TabIndex = 7;
            this.EmpPictureBox3.TabStop = false;
            this.EmpPictureBox3.Visible = false;
            // 
            // EmpPictureBox2
            // 
            this.EmpPictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("EmpPictureBox2.Image")));
            this.EmpPictureBox2.Location = new System.Drawing.Point(222, 69);
            this.EmpPictureBox2.Name = "EmpPictureBox2";
            this.EmpPictureBox2.Size = new System.Drawing.Size(30, 50);
            this.EmpPictureBox2.TabIndex = 6;
            this.EmpPictureBox2.TabStop = false;
            this.EmpPictureBox2.Visible = false;
            // 
            // EmpPictureBox1
            // 
            this.EmpPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("EmpPictureBox1.Image")));
            this.EmpPictureBox1.Location = new System.Drawing.Point(183, 17);
            this.EmpPictureBox1.Name = "EmpPictureBox1";
            this.EmpPictureBox1.Size = new System.Drawing.Size(30, 50);
            this.EmpPictureBox1.TabIndex = 5;
            this.EmpPictureBox1.TabStop = false;
            // 
            // AvgWaitingTimeValue
            // 
            this.AvgWaitingTimeValue.AutoSize = true;
            this.AvgWaitingTimeValue.Location = new System.Drawing.Point(118, 309);
            this.AvgWaitingTimeValue.Name = "AvgWaitingTimeValue";
            this.AvgWaitingTimeValue.Size = new System.Drawing.Size(13, 13);
            this.AvgWaitingTimeValue.TabIndex = 4;
            this.AvgWaitingTimeValue.Text = "0";
            // 
            // AvgWaitingTimeLabel
            // 
            this.AvgWaitingTimeLabel.AutoSize = true;
            this.AvgWaitingTimeLabel.Location = new System.Drawing.Point(3, 309);
            this.AvgWaitingTimeLabel.Name = "AvgWaitingTimeLabel";
            this.AvgWaitingTimeLabel.Size = new System.Drawing.Size(105, 13);
            this.AvgWaitingTimeLabel.TabIndex = 3;
            this.AvgWaitingTimeLabel.Text = "Average waiting time";
            // 
            // SumOfWaitingTimeValue
            // 
            this.SumOfWaitingTimeValue.AutoSize = true;
            this.SumOfWaitingTimeValue.Location = new System.Drawing.Point(118, 291);
            this.SumOfWaitingTimeValue.Name = "SumOfWaitingTimeValue";
            this.SumOfWaitingTimeValue.Size = new System.Drawing.Size(13, 13);
            this.SumOfWaitingTimeValue.TabIndex = 2;
            this.SumOfWaitingTimeValue.Text = "0";
            // 
            // SumWaitingTimeLabel
            // 
            this.SumWaitingTimeLabel.AutoSize = true;
            this.SumWaitingTimeLabel.Location = new System.Drawing.Point(3, 291);
            this.SumWaitingTimeLabel.Name = "SumWaitingTimeLabel";
            this.SumWaitingTimeLabel.Size = new System.Drawing.Size(98, 13);
            this.SumWaitingTimeLabel.TabIndex = 1;
            this.SumWaitingTimeLabel.Text = "Sum of waiting time";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(460, 272);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // StartStopButton
            // 
            this.StartStopButton.Location = new System.Drawing.Point(15, 309);
            this.StartStopButton.Name = "StartStopButton";
            this.StartStopButton.Size = new System.Drawing.Size(147, 23);
            this.StartStopButton.TabIndex = 0;
            this.StartStopButton.Text = "Start simulation";
            this.StartStopButton.UseVisualStyleBackColor = true;
            this.StartStopButton.Click += new System.EventHandler(this.StartStopButtonClick);
            // 
            // EmloyeeNumberLabel
            // 
            this.EmloyeeNumberLabel.AutoSize = true;
            this.EmloyeeNumberLabel.Location = new System.Drawing.Point(12, 17);
            this.EmloyeeNumberLabel.Name = "EmloyeeNumberLabel";
            this.EmloyeeNumberLabel.Size = new System.Drawing.Size(103, 13);
            this.EmloyeeNumberLabel.TabIndex = 1;
            this.EmloyeeNumberLabel.Text = "Number of emloyees";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Location = new System.Drawing.Point(12, 81);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(99, 13);
            this.DurationLabel.TabIndex = 2;
            this.DurationLabel.Text = "Duration of process";
            // 
            // CustomerNumberLabel
            // 
            this.CustomerNumberLabel.AutoSize = true;
            this.CustomerNumberLabel.Location = new System.Drawing.Point(12, 145);
            this.CustomerNumberLabel.Name = "CustomerNumberLabel";
            this.CustomerNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.CustomerNumberLabel.TabIndex = 3;
            this.CustomerNumberLabel.Text = "Customer / Hour";
            // 
            // SettingsPanel
            // 
            this.SettingsPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SettingsPanel.Controls.Add(this.CustomerTrackBar);
            this.SettingsPanel.Controls.Add(this.DurationTrackBar);
            this.SettingsPanel.Controls.Add(this.EmployeeTrackBar);
            this.SettingsPanel.Controls.Add(this.CustomerNumberLabel);
            this.SettingsPanel.Controls.Add(this.DurationLabel);
            this.SettingsPanel.Controls.Add(this.EmloyeeNumberLabel);
            this.SettingsPanel.Controls.Add(this.StartStopButton);
            this.SettingsPanel.Location = new System.Drawing.Point(12, 27);
            this.SettingsPanel.Name = "SettingsPanel";
            this.SettingsPanel.Size = new System.Drawing.Size(180, 374);
            this.SettingsPanel.TabIndex = 0;
            // 
            // CustomerTrackBar
            // 
            this.CustomerTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsManagerBindingSource, "CustomerPerHour", true));
            this.CustomerTrackBar.Location = new System.Drawing.Point(7, 173);
            this.CustomerTrackBar.Maximum = 60;
            this.CustomerTrackBar.Minimum = 1;
            this.CustomerTrackBar.Name = "CustomerTrackBar";
            this.CustomerTrackBar.Size = new System.Drawing.Size(155, 45);
            this.CustomerTrackBar.TabIndex = 6;
            this.CustomerTrackBar.Tag = "";
            this.CustomerTrackBar.TickFrequency = 10;
            this.CustomerTrackBar.Value = 1;
            this.CustomerTrackBar.Scroll += new System.EventHandler(this.CustomerTrackBar_Scroll);
            // 
            // settingsManagerBindingSource
            // 
            this.settingsManagerBindingSource.DataSource = typeof(BankCustomerSimulation.SettingsManager);
            // 
            // DurationTrackBar
            // 
            this.DurationTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsManagerBindingSource, "Duration", true));
            this.DurationTrackBar.Location = new System.Drawing.Point(7, 97);
            this.DurationTrackBar.Maximum = 20;
            this.DurationTrackBar.Minimum = 10;
            this.DurationTrackBar.Name = "DurationTrackBar";
            this.DurationTrackBar.Size = new System.Drawing.Size(155, 45);
            this.DurationTrackBar.SmallChange = 5;
            this.DurationTrackBar.TabIndex = 5;
            this.DurationTrackBar.Value = 10;
            this.DurationTrackBar.Scroll += new System.EventHandler(this.DurationTrackBar_Scroll);
            // 
            // EmployeeTrackBar
            // 
            this.EmployeeTrackBar.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsManagerBindingSource, "EmployeeNumber", true));
            this.EmployeeTrackBar.Location = new System.Drawing.Point(7, 33);
            this.EmployeeTrackBar.Maximum = 3;
            this.EmployeeTrackBar.Minimum = 1;
            this.EmployeeTrackBar.Name = "EmployeeTrackBar";
            this.EmployeeTrackBar.Size = new System.Drawing.Size(155, 45);
            this.EmployeeTrackBar.TabIndex = 4;
            this.EmployeeTrackBar.Value = 1;
            this.EmployeeTrackBar.Scroll += new System.EventHandler(this.EmployeeTrackBar_Scroll);
            // 
            // GlobalTimer
            // 
            this.GlobalTimer.Enabled = true;
            this.GlobalTimer.Interval = 3600;
            this.GlobalTimer.Tick += new System.EventHandler(this.GlobalTimer_Tick);
            // 
            // CustomerTimer
            // 
            this.CustomerTimer.Enabled = true;
            this.CustomerTimer.Tick += new System.EventHandler(this.CustomerTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hideg Lóránt János (FG1D0N) TMPK - 2012";
            // 
            // BankSimulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 416);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SettingsPanel);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BankSimulationForm";
            this.Text = "Bank customer simulation";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerPictBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.SettingsPanel.ResumeLayout(false);
            this.SettingsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingsManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DurationTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeeTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button StartStopButton;
        private System.Windows.Forms.Label EmloyeeNumberLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Label CustomerNumberLabel;
        private System.Windows.Forms.Panel SettingsPanel;
        private System.Windows.Forms.TrackBar CustomerTrackBar;
        private System.Windows.Forms.TrackBar DurationTrackBar;
        private System.Windows.Forms.TrackBar EmployeeTrackBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource settingsManagerBindingSource;
        private System.Windows.Forms.Timer GlobalTimer;
        private System.Windows.Forms.Label SumWaitingTimeLabel;
        private System.Windows.Forms.Label SumOfWaitingTimeValue;
        private System.Windows.Forms.Label AvgWaitingTimeValue;
        private System.Windows.Forms.Label AvgWaitingTimeLabel;
        private System.Windows.Forms.PictureBox EmpPictureBox3;
        private System.Windows.Forms.PictureBox EmpPictureBox2;
        private System.Windows.Forms.PictureBox EmpPictureBox1;
        private System.Windows.Forms.PictureBox CustomerPictBox5;
        private System.Windows.Forms.PictureBox CustomerPictBox4;
        private System.Windows.Forms.PictureBox CustomerPictBox3;
        private System.Windows.Forms.PictureBox CustomerPictBox2;
        private System.Windows.Forms.PictureBox CustomerPictBox1;
        private System.Windows.Forms.Timer CustomerTimer;
        private System.Windows.Forms.Label WaitingCustomerValue;
        private System.Windows.Forms.Label WaitingCustomerLabel;
        private System.Windows.Forms.Label label1;

    }
}

