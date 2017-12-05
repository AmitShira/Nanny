using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public int BankNumber { get; set; }
        public String BankName { get; set; }
        public int BankBranch { get; set; }
        public Address BankAdress { get; set; }
        public int Balance { get; set; }
        public override string ToString()
        {
            string result = "Bank Account details:\n";
            result += "---------------------\n";
            result += string.Format("Accout number: {0}\n", AccountNumber);
            //......
            result += BankAdress.ToString() + '\n';
            return result;
        }
    }
}
