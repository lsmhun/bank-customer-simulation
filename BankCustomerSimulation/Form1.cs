using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BankCustomerSimulation
{
    /// <summary>
    /// Nem túl szép megvalósítás, de mintaprogramhoz elég. Lényegében a GUI eseményeit, 
    /// valamint a Ticker-ek eseményeit kezeljük innen.
    /// </summary>
    public partial class BankSimulationForm : Form
    {
        public BankSimulationForm()
        {
            SettingsManager.Instance.EmployeeNumber = 1;
            SettingsManager.Instance.Duration = 10;
            SettingsManager.Instance.CustomerPerHour = 1;
            InitializeComponent();
        }

        private void StartStopButtonClick(object sender, EventArgs e)
        {
            SettingsManager.Instance.SimulationManager.StartStopSimulation();
            StartStopButton.Text = (SettingsManager.Instance.IsRunningSimulation)?"Stop simulation":"Start simulation";
            
            EmployeeTrackBar.Enabled = (!SettingsManager.Instance.IsRunningSimulation);
            DurationTrackBar.Enabled = (!SettingsManager.Instance.IsRunningSimulation);
            CustomerTrackBar.Enabled = (!SettingsManager.Instance.IsRunningSimulation);
            RefreshEmpPictures();
        }

        private void EmployeeTrackBar_Scroll(object sender, EventArgs e)
        {
            SettingsManager.Instance.EmployeeNumber = EmployeeTrackBar.Value;
            RefreshEmpPictures();
            
        }
        private void RefreshEmpPictures()
        {
            switch(SettingsManager.Instance.EmployeeNumber){
                case 1: EmpPictureBox1.Visible = true; EmpPictureBox2.Visible = false; EmpPictureBox3.Visible = false; break;
                case 2: EmpPictureBox1.Visible = true; EmpPictureBox2.Visible = true; EmpPictureBox3.Visible = false; break;
                case 3: EmpPictureBox1.Visible = true; EmpPictureBox2.Visible = true; EmpPictureBox3.Visible = true; break;
                default: EmpPictureBox1.Visible = true; EmpPictureBox2.Visible = false; EmpPictureBox3.Visible = false;
                    break;
            }
        }

        private void DurationTrackBar_Scroll(object sender, EventArgs e)
        {
            SettingsManager.Instance.EmployeeNumber = DurationTrackBar.Value;
        }

        private void CustomerTrackBar_Scroll(object sender, EventArgs e)
        {
            SettingsManager.Instance.CustomerPerHour = CustomerTrackBar.Value;
        }

        private void GlobalTimer_Tick(object sender, EventArgs e)
        {
            SettingsManager.Instance.SimulationManager.SyncState();
            
        }

        private void CustomerTimer_Tick(object sender, EventArgs e)
        {
            this.SumOfWaitingTimeValue.Text = SettingsManager.Instance.SumWaitingTime.ToString();
            var doubleVal = System.Convert.ToDouble(SettingsManager.Instance.SumWaitingTime);
            var doubleVal2 = System.Convert.ToDouble(SettingsManager.Instance.SimulationManager.MyCustomerCounter);
            this.AvgWaitingTimeValue.Text = (doubleVal2 != 0) ? (doubleVal / doubleVal2).ToString("####0.0") : "0.0";
            SettingsManager.Instance.SimulationManager.RefreshWaitingCustomerNumber();
            switch (SettingsManager.Instance.CurrentlyWaitingCustomer)
            {
                case 0:
                    CustomerPictBox1.Visible = false;CustomerPictBox2.Visible = false;CustomerPictBox3.Visible = false;CustomerPictBox4.Visible = false;CustomerPictBox5.Visible = false;
                    break;
                case 1: CustomerPictBox1.Visible = true; CustomerPictBox2.Visible = false; CustomerPictBox3.Visible = false; CustomerPictBox4.Visible = false; CustomerPictBox5.Visible = false;
                    break;
                case 2: CustomerPictBox1.Visible = true; CustomerPictBox2.Visible = true; CustomerPictBox3.Visible = false; CustomerPictBox4.Visible = false; CustomerPictBox5.Visible = false;
                    break;
                case 3: CustomerPictBox1.Visible = true; CustomerPictBox2.Visible = true; CustomerPictBox3.Visible = true; CustomerPictBox4.Visible = false; CustomerPictBox5.Visible = false;
                    break;
                case 4: CustomerPictBox1.Visible = true; CustomerPictBox2.Visible = true; CustomerPictBox3.Visible = true; CustomerPictBox4.Visible = true; CustomerPictBox5.Visible = false;
                    break;
                default: CustomerPictBox1.Visible = true; CustomerPictBox2.Visible = true; CustomerPictBox3.Visible = true; CustomerPictBox4.Visible = true; CustomerPictBox5.Visible = true;
                    break;
            }
            WaitingCustomerValue.Text = SettingsManager.Instance.CurrentlyWaitingCustomer.ToString();
        }


        
    }
}
