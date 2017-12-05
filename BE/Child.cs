using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public class Child//:person
    {
        public String ID { get; set; }
        public String MotherID { get; set; }
        public String FirstName { get; set; }
        public DateTime BirthDate { get; set; }// Public DateTime Birthday {get;set;  }
        public SpecNeeds Needs { get; set; }
        
        public int Age() // פונקציה שמחשבת גיל בחודשים (כל גיל)
        {
            DateTime BirthDate_ = new DateTime(BirthDate.Year, BirthDate.Month,BirthDate.Day);
            DateTime now = DateTime.Today;
            int age = 0;

            // Calculation of child's age.
            int Age_By_Month = now.Month - BirthDate_.Month;
            // int Age_By_Day = now.Day - BirthDate_.Day;
            int Age_By_Year = now.Year - BirthDate_.Year;

            age = (Age_By_Year * 12);
            age += Age_By_Month;

            return age;
        }

        public override string ToString()
        {
            string result = ID + "\n" + FirstName + "\n";
            result += BirthDate.ToString() + "\n";
            return result;
        }

    }
}

//public float Age()
//{
//    TimeSpan timeSpan = DateTime.Now - DateTime.bi;
//    float age = timeSpan.Days / 365;
//    return age;
//}