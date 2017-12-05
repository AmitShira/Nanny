using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public abstract class Person
    {
        public String ID { get; set; }
        public String Lastname { get; set; }
        public String FirstName { get; set; }
        public String Tel { get; set; }
        public Address Address { get; set; }
        public DateTime BirthDate { get; set; }
        
        public override string ToString()
        {
            return ID + "\n" + Lastname + "\n" + FirstName + "\n" + Tel + "\n";
        }
    }
}
