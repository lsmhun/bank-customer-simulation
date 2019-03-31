using System;

namespace BankCustomerSimulation
{
    /// <summary>
    /// Singleton for basic data changing
    /// </summary>
    internal class SettingsManager
    {
        #region Singleton additions 

        private static volatile SettingsManager instance;
        private static object syncRoot = new object();

        private SettingsManager()
        {
            EmployeeNumber = 0;
        }

        public static SettingsManager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new SettingsManager();
                    }
                }

                return instance;
            }
        }

        #endregion Singleton additions


        public int EmployeeNumber { get; set; }

        // customer and employee 
        public int Duration { get; set; }

        public int CustomerPerHour { get; set; }
        public int SumWaitingTime { get; set; } = 0;

        public Boolean IsRunningSimulation { get; set; }
        public SimulationManager SimulationManager { get; } = new SimulationManager();

        public const int SimulationSpeed = 600;

        public void AddWaitingTime(int waitTime)
        {
            SumWaitingTime += waitTime;
        }

        public int CurrentlyWaitingCustomer { get; set; }

        public void Reset()
        {
            SumWaitingTime = 0;
            CurrentlyWaitingCustomer = 0;
        }
    }
}