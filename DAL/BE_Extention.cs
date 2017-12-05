using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    internal static class BE_Extention
    {
        public static Child ChildDeepClone(this Child source)
        {
            return new Child
            {
                FirstName = source.FirstName,
                ID = source.ID,
                MotherID = source.MotherID,
                BirthDate = new DateTime((source.BirthDate).Year, source.BirthDate.Month, source.BirthDate.Day),
                Needs = source.Needs
            };
        }


        public static Mother MotherDeepClone(this Mother source)
        {
            return new Mother
            {
                FirstName = source.FirstName,
                ID = source.ID,
                TelNossaf = source.TelNossaf,
                GoalAdress = source.GoalAdress,
                Lastname = source.Lastname,
                Tel = source.Tel,
                Workhours = source.Workhours,
                Address = source.Address,
                BankDetails = source.BankDetails
            };
        }

        public static Nanny NannyDeepClone(this Nanny source)
        {
            return new Nanny
            {
                Address = source.Address,
                BirthDate = new DateTime((source.BirthDate).Year, source.BirthDate.Month, source.BirthDate.Day),
                FirstName = source.FirstName,
                Lastname = source.Lastname,
                ID = source.ID,
                Tel = source.Tel,
                RangeAge = source.RangeAge

            };
        }
        public static Contract ContractDeepClone(this Contract source)
        {
            return new Contract
            {
                ContractID = source.ContractID,
                NannyID = source.NannyID,
                ChildID = source.ChildID,
                MotherID=source.MotherID,
                SalaryPerHour = source.SalaryPerHour,
                SalaryPerMonth = source.SalaryPerMonth,
                Interview = source.Interview,
                SignedContract = source.SignedContract,
                Siblings = source.Siblings,
                Workhours = new Dictionary<DayOfWeek, KeyValuePair<int, int>>(source.Workhours),
                StartWork = new DateTime((source.StartWork).Year, source.StartWork.Month, source.StartWork.Day),
                EndWork = new DateTime((source.EndWork).Year, source.EndWork.Month, source.EndWork.Day),
                HoursOfContract = source.HoursOfContract,
                Tariff = source.Tariff
            };
        }
    }
}