using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : Idal
    {

        public void AddChild(Child child)
        {
            if (!DS.DataSource.List_of_Children.Any(item => item.ID == child.ID))
                DS.DataSource.List_of_Children.Add(child.ChildDeepClone());
            else throw new Exception("ERROR!: Child already exists\n");
 
        }

        public void AddContract(Contract contract)
        {  
            DS.DataSource.List_of_Contracts.Add(contract.ContractDeepClone());
        }

        public void AddMother(Mother mother)
        {
            if (!DS.DataSource.List_of_Mothers.Any(item => item.ID == mother.ID))
                DS.DataSource.List_of_Mothers.Add(mother.MotherDeepClone());
            else throw new Exception("ERROR: Mother already exists in system\n");
        }
        public void AddNanny(Nanny nanny)
        {
            if (!DS.DataSource.List_of_Nannies.Any(item => item.ID == nanny.ID))
                DS.DataSource.List_of_Nannies.Add(nanny.NannyDeepClone());//keep order according to mothers?
            else throw new Exception("ERROR!: Nanny already exists\n");
        }

        public void DeleteChild(Child child)
        {
            if ( DS.DataSource.List_of_Children.Find(item => item.ID == child.ID)==null)
                throw new Exception("ERROR : Child Dosn't exist in system\n");
            child = DS.DataSource.List_of_Children.Find(item => item.ID == child.ID);
                DS.DataSource.List_of_Children.Remove(child);
        }

        public void DeleteContract(Contract contract)
        { 
            if (DS.DataSource.List_of_Contracts.Find(item => item.ContractID == contract.ContractID) == null)
                throw new Exception("ERROR: Contract Dosn't exist \n");
            contract = DS.DataSource.List_of_Contracts.Find(item => item.ContractID == contract.ContractID);

            DS.DataSource.List_of_Contracts.Remove(contract);
        }

        public void DeleteMother(Mother mother)
        {
            if (DS.DataSource.List_of_Mothers.Find(item => item.ID == mother.ID) == null)
                throw new Exception("ERROR!: Mother Dosn't exist in system\n");
            mother = DS.DataSource.List_of_Mothers.Find(item => item.ID == mother.ID);
            DS.DataSource.List_of_Mothers.Remove(mother);
        }

        public void DeleteNanny(Nanny nanny)
        {
            if (DS.DataSource.List_of_Nannies.Find(item => item.ID == nanny.ID) == null)
                throw new Exception("ERROR: Nanny Dosn't exist \n");
            nanny = DS.DataSource.List_of_Nannies.Find(item => item.ID == nanny.ID);
            DS.DataSource.List_of_Nannies.Remove(nanny);

        }

        public List<BankAccount> getAllBankBranches()
        {
            if (DS.DataSource.List_of_BankBranches == null)
            {
                DS.DataSource.List_of_BankBranches.Add(new BankAccount { AccountNumber = 123, BankNumber = 12, BankName = "Leumi", BankBranch = 10, BankAdress = new Address { Number = 21, Street = "Ramban", City = "Jerusalem", Country = "Israel", ZipCode = "945415" } });
                DS.DataSource.List_of_BankBranches.Add(new BankAccount { AccountNumber = 456, BankNumber = 10, BankName = "Hapoalim", BankBranch = 80, BankAdress = new Address { Number = 9, Street = "Hhagana", City = "Tel Aviv", Country = "Israel", ZipCode = "235415" } });
                DS.DataSource.List_of_BankBranches.Add(new BankAccount { AccountNumber = 789, BankNumber = 11, BankName = "Discount", BankBranch = 60, BankAdress = new Address { Number = 32, Street = "nagara", City = "Beer Sheva", Country = "Israel", ZipCode = "944174" } });
                DS.DataSource.List_of_BankBranches.Add(new BankAccount { AccountNumber = 101, BankNumber = 13, BankName = "Israel", BankBranch = 70, BankAdress = new Address { Number = 02, Street = "nili", City = "Eilat", Country = "Israel", ZipCode = "986421" } });
                DS.DataSource.List_of_BankBranches.Add(new BankAccount { AccountNumber = 112, BankNumber = 14, BankName = "Yahav", BankBranch = 40, BankAdress = new Address { Number = 18, Street = "palmach", City = "Jerusalem", Country = "Israel", ZipCode = "865834" } });
            }
            return DS.DataSource.List_of_BankBranches;
        }





        public List<Child> getAllChilds()
        {
            return DS.DataSource.List_of_Children.Select(item => item.ChildDeepClone()).ToList();
        }

        public List<Contract> getAllContracts()
        {
            return DS.DataSource.List_of_Contracts.Select(item => item.ContractDeepClone()).ToList();
        }

        public IEnumerable<Mother> getAllMothers()
        {

            return DS.DataSource.List_of_Mothers.Select(item => item.MotherDeepClone()).ToList();
        }

        public List<Nanny> getAllNannys()
        {
            return DS.DataSource.List_of_Nannies.Select(item => item.NannyDeepClone()).ToList();
        }

        public List<Child> getAllChildsByMother(Mother mother)
        {
            return DS.DataSource.List_of_Children.Select(item => item.ChildDeepClone()).ToList();
        }

        public void UpdateChild(Child child)
        {
            DeleteChild(child);
            AddChild(child);

        }

        public void UpdateContract(Contract contract)
        {
            Contract item = DS.DataSource.List_of_Contracts.Find(c => c.ContractID == contract.ContractID);
            if (item == null)
                throw new Exception("ERROR!: Contract Dosn't exist in system\n");
            
        }

        public void UpdateMother(Mother mother)
        {
            DeleteMother(mother);
            AddMother(mother);
        }

        public void UpdateNanny(Nanny nanny)
        {
            DeleteNanny(nanny);
            AddNanny(nanny);
        }    
    }
}
