using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Collections;

namespace BankCustomerSimulation
{

    class SimulationManager
    {
        private int _myCustomerCounter = 0;
      
        private ArrayList customers = new ArrayList();
  
        private ArrayList employees = new ArrayList();

        public int MyCustomerCounter
        {
            get { return _myCustomerCounter; }
        }

        public bool HasFreeEmployee { 
            get
            {
                foreach (EmployeeThread employee in employees)
                {
                    if (employee.IsFree)
                    {
                        employee.WorkWithCustomer();
                        return true;
                    }
                }
                return false;
            }
        }

        public void StartStopSimulation()
        {
            if(!SettingsManager.Instance.IsRunningSimulation)
            {
                CleanPool();
                SettingsManager.Instance.Reset();
                _myCustomerCounter = 0;
                for (var e = 0; e < SettingsManager.Instance.EmployeeNumber;e++ )
                {
                    var et = new EmployeeThread(e.ToString());
                    employees.Add(et);
                    var t = new Thread(et.StayInDesk);
                    t.Start();
                    
                }   
            }else
            {
                CleanPool();
            }
            SettingsManager.Instance.IsRunningSimulation = !SettingsManager.Instance.IsRunningSimulation;
        }

        public void CleanPool()
        {
            // clear
            Console.WriteLine("Thread pool clearing...");
            
            foreach (CustomerThread customer in customers)
            {
                customer.RequestStop();
            }
            foreach (EmployeeThread employee in employees)
            {
                employee.RequestStop();
            }
            customers.Clear();
            employees.Clear();
        }

        public void SyncState()
        {
            if (!SettingsManager.Instance.IsRunningSimulation) return;
            // if we have got more than 50 customers, then we should
            if (SettingsManager.Instance.CurrentlyWaitingCustomer >= 50) return;
            for (var c = 0; c < SettingsManager.Instance.CustomerPerHour; c++)
            {
                var ct = new CustomerThread(GetNextNumberOfCounter().ToString());
                customers.Add(ct);
                var t = new Thread(ct.DoMyJob);
                t.Start();
            }

        }

        public int GetNextNumberOfCounter()
        {
            _myCustomerCounter++;
            return _myCustomerCounter;
        }

        public void RefreshWaitingCustomerNumber()
        {
            int currentWaitingPeople = customers.Cast<CustomerThread>().Count(customer => !customer.IsReady);
            SettingsManager.Instance.CurrentlyWaitingCustomer = currentWaitingPeople;
        }
    }
   
}
