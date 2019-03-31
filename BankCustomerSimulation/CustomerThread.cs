using System;
using System.Threading;

namespace BankCustomerSimulation
{
    /// <summary>
    /// Customer representation thread
    /// </summary>
    class CustomerThread
    {

        public bool IsReady { get; set; }

        public string Name { get; } = "";

        private int Age { get; set; }

        public CustomerThread()
        {
            Age = 0;
        }
        public CustomerThread(string customerName)
        {
            if (string.IsNullOrWhiteSpace(customerName))
            {
                throw new ArgumentException("message", nameof(customerName));
            }

            Age = 0;
            Name = customerName;
            IsReady = false;
            
        }

        /// <summary>
        /// Customer has to wait for bank employee
        /// </summary>
        public void DoMyJob()
        {
            while (!IsReady)
            {
                if (SettingsManager.Instance.SimulationManager.HasFreeEmployee)
                {
                    IsReady = true;
                    Thread.Sleep(SettingsManager.Instance.Duration * SettingsManager.SimulationSpeed);

                    WriteState();
                }
                else
                {
                    Age += 1;
                    SettingsManager.Instance.AddWaitingTime(1);
                    Thread.Sleep(SettingsManager.SimulationSpeed);
                    WriteState();
                }

            }
        }

        /// <summary>
        /// End of simulation
        /// </summary>
        public void RequestStop()
        {
            IsReady = true;
        }

        public void WriteState()
        {
            Console.WriteLine(!IsReady ? "#" + Name + " is waiting for bank employee..." : "I am ready!");
        }

    }
}
