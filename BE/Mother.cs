
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Mother : Person
    {
        public String TelNossaf { get; set; }
        public Address GoalAdress { get; set; }
        public Dictionary<DayOfWeek, KeyValuePair<int, int>> Workhours { get; set; }
        public BankAccount BankDetails { get; set; }

        public override string ToString()
        {
            string result = base.ToString();


            result += (TelNossaf != null) ? "Tel Nosaf: " + TelNossaf + '\n' : "";
            result += (GoalAdress.Street != null) ? "mikum nidrash: " + GoalAdress + "\n" : "";
            foreach (var item in Workhours)
            {
                result += "yom: " + item.Key + "   \t";
                result += "shaot " + item.Value.Key + " : " + item.Value.Value + '\n';
            }
            return result;
        }
    }
}