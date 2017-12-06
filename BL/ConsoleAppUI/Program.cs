using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BL;
using BE;

namespace ConsoleAppUI
{
    class Program
    {
        private static Ibl Mybl = FactoryBl.getBL();

        static void Main(string[] args)
        {
            Address A1 = new Address { Number = 26, Street = "Givat Shaul", City = "JERUSALEM", ZipCode = "123", Country = "Israel" };
            Address A2 = new Address { Number = 9, Street = "hirshenberg", City = "JERUSALEM", ZipCode = "456", Country = "Israel" };
            Address A3 = new Address { Number =7, Street = "Beit Hdfus ", City = "JERUSALEM", ZipCode = "222", Country = "Israel" };
            Address A4 = new Address { Number = 30, Street = "Ha-Kablan ", City = "JERUSALEM", ZipCode = "222", Country = "Israel" };

            DateTime B1 = new DateTime(1994, 3, 26);
            DateTime B2 = new DateTime(1995,2,25);
            DateTime B3 = new DateTime(1989, 10, 13);
            DateTime B4 = new DateTime(2015, 1, 13);
            DateTime B5 = new DateTime(2014, 11, 24);

            Dictionary<DayOfWeek, KeyValuePair<int, int>> D1 = new Dictionary<DayOfWeek, KeyValuePair<int, int>>() { { DayOfWeek.Sunday, new KeyValuePair<int, int>(7, 9) }, {DayOfWeek.Monday, new KeyValuePair<int, int>(8,14)} };
            Dictionary<DayOfWeek, KeyValuePair<int, int>> D2 = new Dictionary<DayOfWeek, KeyValuePair<int, int>>() { { DayOfWeek.Thursday, new KeyValuePair<int, int>(6, 12) }, { DayOfWeek.Friday, new KeyValuePair<int, int>(10, 11) } };
            Dictionary<DayOfWeek, KeyValuePair<int, int>> D3 = new Dictionary<DayOfWeek, KeyValuePair<int, int>>() { { DayOfWeek.Monday, new KeyValuePair<int, int>(11, 16) }, { DayOfWeek.Tuesday, new KeyValuePair<int, int>(12, 15) } };

            BankAccount C1 = new BankAccount { AccountNumber = 89, BankNumber = 453, BankName = "leumi", BankBranch = 12, BankAdress = A2, Balance = 20000 };
            BankAccount C2 = new BankAccount { AccountNumber = 11, BankNumber = 789, BankName = "POALIM", BankBranch = 10, BankAdress = A1, Balance = 12000 };
            BankAccount C3 = new BankAccount { AccountNumber = 22, BankNumber = 777, BankName = "leumi", BankBranch = 8, BankAdress = A3, Balance = 8000 };
            BankAccount C4 = new BankAccount { AccountNumber = 123, BankNumber = 456, BankName = "leumi", BankBranch = 7, BankAdress = A3, Balance = 700 };
            BankAccount C5 = new BankAccount { AccountNumber = 876, BankNumber = 999, BankName = "Poalim", BankBranch = 10, BankAdress = A2, Balance = 1330 };


            Mother m1 = new Mother { ID = "111", Lastname = "Babiev", FirstName = "amit_shira", Tel = "0535330388", Address = A1, BirthDate = B2, TelNossaf = "333", GoalAdress = A3, Workhours = D1, BankDetails = C1 };
            Mother m2 = new Mother { ID = "222", Lastname = "kierszen", FirstName = "orly", Tel = "0548489226", Address = A2, BirthDate = B1, TelNossaf = "444", GoalAdress = A1, Workhours = D2, BankDetails = C2 };
            Mother m3 = new Mother { ID = "333", Lastname = "mord", FirstName = "yeal", Tel = "0542118022", Address = A3, BirthDate = B3, TelNossaf = "666", GoalAdress = A2, Workhours = D3, BankDetails = C3 };

            Nanny N1 = new Nanny { Address = A4, BankDetails = C4, BirthDate = B2, Elevator = true, FirstName = "NannyBanny", Lastname = "i love kids", ID = "444", MaxKids = 3, MaxChildAge = 72, MinChildAge = 1, TariffPerHour = 30, Tel = "12345668", VacDaysTamat = false, Workhours = D2, YearsOfExperience = 2, recommend = "I'm cooking well", TariffPerMonth = 3000 };
            Nanny N2 = new Nanny { Address = A3, BankDetails = C5, BirthDate = B2, Elevator = false, FirstName = "anny", Lastname = "AAAA", ID = "555", MaxKids =18, MaxChildAge = 50, MinChildAge = 5, TariffPerHour = 30, Tel = "12368", VacDaysTamat = true, Workhours = D3, YearsOfExperience = 3, recommend = "NO!", TariffPerMonth = 2000 };

            Child ch1 = new Child {BirthDate= B4,FirstName="Dani", ID="666",MotherID="111",Needs= SpecNeeds.Celiac};
            Child ch2 = new Child { BirthDate = B5, FirstName = "Ron", ID = "777", MotherID = "222", Needs = SpecNeeds.None };

            Mybl.AddMother(m1);
            Mybl.AddMother(m2);
            Mybl.AddMother(m3);
            Mybl.AddNanny(N1);
            Mybl.AddNanny(N2);
            Mybl.AddChild(ch1);
            Mybl.AddChild(ch2);

            //Mother amother = Mybl.getMotherById("222");
            Mother amother = Mybl.getAllMothers(m => m.ID == "222").FirstOrDefault();
            Nanny nanny = N1;
            Child enfant = ch1;
            Contract contract = new Contract { ChildID = ch1.ID, MotherID = amother.ID, NannyID = nanny.ID };
            Mybl.AddContract(contract);
            foreach (var item in Mybl.getAllMothers())
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();

        }
    }
}
