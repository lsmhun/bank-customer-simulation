using System;
using System.Threading;

namespace BankCustomerSimulation
{
    /// <summary>
    /// Bank employee thread
    /// </summary>
    class EmployeeThread
    {
        private bool _shouldStop = false;
        public string Name { get; } = "";

        public EmployeeThread()
        {
            IsFree = true;
        }

        public EmployeeThread(string no)
        {
            IsFree = true;
            Name = no;
        }
        
        public bool IsFree { get; private set; }

        public void WorkWithCustomer()
        {
            IsFree = false;
            Thread.Sleep(SettingsManager.Instance.Duration * 60);
            IsFree = true;
        }

        public void StayInDesk()
        {
            while (!_shouldStop)
            {
                WriteState();
                Thread.Sleep(SettingsManager.SimulationSpeed);
            }

        }

        public void RequestStop()
        {
            Console.WriteLine("#" + Name + " employee go home...");
            _shouldStop = true;
        }

        public void WriteState()
        {
            Console.WriteLine(IsFree ? "#" + Name + " is waiting for customers..." : "#" + Name + " is working with customer...");
        }
    }
}
