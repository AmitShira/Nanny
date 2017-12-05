using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Nanny : Person
    {
        public DateTime BirthDate { get; set; }
        public bool Elevator { get; set; }
        public int FloorNumber { get; }
        public int YearsOfExperience { get; set; }
        public int MaxKids { get; set; }
        private string rangeage;
        public string RangeAge
        {
            get { return rangeage; }
            set { rangeage = MaxChildAge.ToString() + '-' + MinChildAge.ToString(); } }// the nanny enter the range of the ages of the children

        public int MinChildAge { get; set; } // age by month
        public int MaxChildAge { get; set; } //age by month
        public int TariffPerHour { get; set; }
        public int TariffPerMonth { get; set; }
        public Dictionary<DayOfWeek, KeyValuePair<int, int>> Workhours { get; set; }
        public bool VacDaysTamat { get; set; }
        public string recommend { get; set; }
        public BankAccount BankDetails { get; set; }


        //private int number_of_contracts;
        //public int Number_of_contracts
        //{
        //    get { return number_of_contracts; }
        //    set { number_of_contracts = 0; }
        //}

        public override string ToString()
        {
            string result = base.ToString();
            result += Address.ToString() + "\n";
            result += BirthDate.ToString() + "\n";
            foreach (var item in Workhours)
            {
                result += "yom: " + item.Key + "   \t";
                result += "shaot " + item.Value.Key + " : " + item.Value.Value + '\n';
            }
            return result;
        }
    }
}

