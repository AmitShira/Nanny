using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Contract
    {
        private static int ContractNumber = 10000000; // running code 8 digits
        private int contractid;

        public int ContractID
        {
            get { return contractid; }
            set
            {
                ContractNumber++;
                contractid = ContractNumber;
            }
        }

        public String NannyID { get; set; }
        public String ChildID { get; set; }
        public String MotherID { get; set; }
        public bool Interview { get; set; }
        public bool SignedContract { get; set; }
        public int SalaryPerHour { get; set; }
        public int SalaryPerMonth { get; set; }
        public bool Tariff { get; set; }// if the payment is perHour or perMonth
        public bool Siblings { get; set; }
        public Dictionary<DayOfWeek, KeyValuePair<int, int>> Workhours { get; set; }
        public DateTime StartWork { get; set; }
        public DateTime EndWork { get; set; }
        public int HoursOfContract { get; set; }

        

        public override string ToString()
        {
            string result = "Contract Number: " + ContractNumber + "\n" + "Nanny ID: " + NannyID + "\n" + "Child ID: " + ChildID + "\n";
            result += (SalaryPerHour != 0) ? "Salary Per Hour " + SalaryPerHour + '\n' : "";// check null for int (and not !=0)
            result += (SalaryPerMonth != 0) ? "Salary Per Month " + SalaryPerMonth + '\n' : "";

            return result;
        }
    }
}
