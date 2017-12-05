using System;
using System.Collections.Generic;
using System.Text;

namespace BE
{
    public struct Address
    {
        public int Number { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            string result = "";
            result += Street + " ";
            result += Number + ", ";
            result += City + ", ";
            result += Country;
            return result;

        }
    }
}