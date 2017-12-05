using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;
using DAL;

using System.Text.RegularExpressions;
using System.Threading;
using GoogleMapsApi;
using GoogleMapsApi.Entities.Common;
using GoogleMapsApi.Entities.Directions.Request;
using GoogleMapsApi.Entities.Directions.Response;
using GoogleMapsApi.Entities.Elevation.Request;
using GoogleMapsApi.Entities.Geocoding.Request;
using GoogleMapsApi.Entities.Geocoding.Response;
using GoogleMapsApi.StaticMaps;
using GoogleMapsApi.StaticMaps.Entities;


namespace BL
{
    public class BL_imp : Ibl
    {
       

        public void AddChild(Child child)
        {
            DateTime BirthDate_Child = new DateTime(child.BirthDate.Year, child.BirthDate.Month, child.BirthDate.Day);
            DateTime now = DateTime.Today;

            int AgeByMonth = child.Age();// get the age of the child by month
            if ((AgeByMonth == 3) && (now.Day - BirthDate_Child.Day < 0))// if the age of month is 3, but the Days aren't apropriate
                throw new Exception("ERROR! Too Young!\n");

            Idal mydal = FactoryDal.getDal();
            
            try
            {
                mydal.AddChild(child);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddContract(Contract contract)
        {
            Idal mydal = FactoryDal.getDal();

            Nanny N_temp = new Nanny();
            if (mydal.getAllNannys().Find(item => item.ID == contract.NannyID) != null)
            {
                N_temp = mydal.getAllNannys().Find(item => item.ID == contract.NannyID);
                contract.SalaryPerHour = N_temp.TariffPerHour;// updating tariff of contract according to nanny.
                contract.SalaryPerMonth = N_temp.TariffPerMonth;
            }
            else throw new Exception("ERROR!:Nanny does not exist\n");

            Child M_temp = new Child();
            if (mydal.getAllChilds().Find((item => item.ID == contract.ChildID)) != null)
                M_temp = mydal.getAllChilds().Find(item => item.ID == contract.ChildID);
            else throw new Exception("ERROR!: Child does not exist\n");

            if (!mydal.getAllMothers().Any(item => item.ID == M_temp.MotherID))
                throw new Exception("ERROR!:Mother does not exist\n");

            List<Contract> Nannys_Contracts = new List<Contract>(); // Checking if another contract can be added to specific nanny.
            Nannys_Contracts = mydal.getAllContracts().FindAll(item => item.NannyID == N_temp.ID);
            if (Nannys_Contracts.Count == N_temp.MaxKids)
                throw new Exception("ERROR!:Nanny is full\n");

            if (mydal.getAllContracts().Exists(item => item.MotherID == contract.MotherID))//check if the mother has more children and update if does(הנחה של אמא מול מערכת ולא מול נני)
                contract.Siblings = true;
            try
            {
                mydal.AddContract(contract);
            }
            catch (Exception e)
            {
                throw e;
            }
        }




        public void AddMother(Mother mother)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.AddMother(mother);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddNanny(Nanny nanny)
        {
            DateTime Birthay_nanny = new DateTime(nanny.BirthDate.Year, nanny.BirthDate.Month, nanny.BirthDate.Day);
            DateTime now = DateTime.Today;
            if (now.Year - Birthay_nanny.Year < 18)
            {
                throw new Exception("Too young to be a Nanny/n");
            }

            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.AddNanny(nanny);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteChild(Child child)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.DeleteChild(child);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteContract(Contract contract)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.DeleteContract(contract);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteMother(Mother mother)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.DeleteMother(mother);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void DeleteNanny(Nanny nanny)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.DeleteNanny(nanny);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<BankAccount> getAllBankBranches()
        {
            Idal mydal = FactoryDal.getDal();
            return mydal.getAllBankBranches();
        }

        public List<Child> getAllChilds(Predicate<Child> condition = null)
        {
            Idal mydal = FactoryDal.getDal();
            if (condition == null)
            {
                return mydal.getAllChilds().ToList();
            }
            var result = from c in mydal.getAllChilds()
                         where condition(c)
                         select c;
            return result.ToList();
        }

        public List<Child> getAllChildsByMother(Mother mother)
        {
            Idal mydal = FactoryDal.getDal();
            return mydal.getAllChildsByMother(mother);
        }

        public List<Contract> getAllContracts()
        {
            Idal mydal = FactoryDal.getDal();
            return mydal.getAllContracts();
        }

        public List<Mother> getAllMothers(Predicate<Mother> condition = null)
        {
            Idal mydal = FactoryDal.getDal();
            if (condition == null)
            {
                return mydal.getAllMothers().ToList();
            }
            var result = from m in mydal.getAllMothers()
                         where condition(m)
                         select m;
            return result.ToList();
        }
        public List<Nanny> getAllNannys(Predicate<Nanny> condition = null)
        {
            Idal mydal = FactoryDal.getDal();
            if (condition == null)
            {
                return mydal.getAllNannys().ToList();
            }
            var result = from n in mydal.getAllNannys()
                         where condition(n)
                         select n;
            return result.ToList();
        }

        public void UpdateChild(Child child)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.UpdateChild(child);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateContract(Contract contract)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.UpdateContract(contract);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateMother(Mother mother)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.UpdateMother(mother);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void UpdateNanny(Nanny nanny)
        {
            Idal mydal = FactoryDal.getDal();
            try
            {
                mydal.UpdateNanny(nanny);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int NannySalary(Nanny nanny)// caculate the salary for the nanny 
        {

            List<Contract> ContByNanny = (from Cont in getAllContracts() // 
                                          where Cont.NannyID == nanny.ID
                                          select Cont).ToList();
            int SumSalary = 0;
            int SalaryPerContrct = 0;

            foreach (var Cont in ContByNanny)
            {
                if (Cont.Tariff == true) // by month
                {
                    SalaryPerContrct = nanny.TariffPerMonth;
                    if (Cont.Siblings == true)
                        SalaryPerContrct = (SalaryPerContrct / 100) * 98;
                }

                else   // by hour
                {
                    SalaryPerContrct = (Cont.Workhours.Sum(x => (x.Value.Key - x.Value.Value)) * (nanny.TariffPerHour));
                    if (Cont.Siblings == true)
                        SalaryPerContrct = (SalaryPerContrct / 100) * 98;
                }
                SumSalary += SalaryPerContrct;
            }
            DateTime now = DateTime.Today;
            if (now.Day == 10)

                nanny.BankDetails.Balance += SumSalary;

            return SumSalary;
        }

        public int MotherPayment(Mother mother)
        {

            List<Contract> ContByMother = (from Cont in getAllContracts() // 
                                           where Cont.MotherID == mother.ID
                                           select Cont).ToList();
            int SumPayment = 0;
            int paymentPerContract = 0;

            foreach (var Cont in ContByMother)
            {
                if (Cont.Tariff == true) // by month
                {
                    paymentPerContract = Cont.SalaryPerMonth;
                    if (Cont.Siblings == true)
                        paymentPerContract = (paymentPerContract / 100) * 98;
                }
                else   // by hour
                {
                    paymentPerContract = (Cont.Workhours.Sum(x => (x.Value.Value - x.Value.Key)) * (Cont.SalaryPerHour));
                    if (Cont.Siblings == true)
                        paymentPerContract = (paymentPerContract / 100) * 98;
                }
                SumPayment += paymentPerContract;
            }
            DateTime now = DateTime.Today;
            if (now.Day == 10)
                mother.BankDetails.Balance -= SumPayment;

            return SumPayment;
        }

        public List<Nanny> Potential_Nanny(Child child, Mother mother)
        {
          
            List<Nanny> PotentialNannyList = new List<Nanny>();

            var PotentialNannyL = (from nan in getAllNannys()
                                   where (child.Age() <= nan.MaxChildAge) && (child.Age() >= nan.MinChildAge)
                                   select nan).ToList();

            foreach (var naan in PotentialNannyL)
            {
                foreach (var DayM in mother.Workhours)
                    foreach (var DayN in naan.Workhours)
                    {
                        if (DayM.Key == DayN.Key)
                            if ((DayM.Value.Key >= DayN.Value.Key) && (DayM.Value.Value <= DayN.Value.Value))
                                PotentialNannyList.Add(naan);
                    }
            }

            List<Nanny> PotentialNanny;
            if (mother.GoalAdress.Street != null)
            {
                PotentialNanny = (from nany in PotentialNannyList
                                  where (Distance(mother.GoalAdress.ToString(), nany.Address.ToString()) < 10000)
                                  select nany).ToList();
            }
            else
            {
                PotentialNanny = (from nany in PotentialNannyList
                                  where (Distance(mother.Address.ToString(), nany.Address.ToString()) < 10000)
                                  select nany).ToList();

            }
            return PotentialNanny;
        }

         public List<Child> NannyLessChldrn()
        {
            List<Child> ChildwithoutNanny = new List<Child>();
           
            foreach (var Child in getAllChilds())
                foreach (var Contract in getAllContracts())
                    if (Child.ID != Contract.ChildID)
                        ChildwithoutNanny.Add(Child);
            return ChildwithoutNanny;
        }
        public double Distance(String origin, String destination)
        {
            var drivingDirectionRequest = new DirectionsRequest
            {
                TravelMode = TravelMode.Walking,
                Origin = origin,
                Destination = destination

            };
            DirectionsResponse drivingDirections = GoogleMaps.Directions.Query(drivingDirectionRequest);
            Leg leg = PrintDirections(drivingDirections);

            return leg.Distance.Value;
        }

        private static Leg PrintDirections(DirectionsResponse directions)
        {
            Route route = directions.Routes.First();
            Leg leg = route.Legs.First();

            return leg;
        }

        public List<Nanny>Tamat_Vacation() 
        {
            var TamatNanny = (from nanny in getAllNannys()
                                  where (nanny.VacDaysTamat==true)
                                  select nanny).ToList();
            return TamatNanny;
        }

        public List<Contract> ConditionContract(Predicate<Contract> condition) // return all the contracts according to condition
        {
            var SContract = (from Cont in getAllContracts()
                              where (condition(Cont))
                              select Cont).ToList();
            return SContract;
        }

        public int ConditionNumberContract(Predicate<Contract> condition)  // return the number of the contracts according to condition
        { int count = ConditionContract(condition).Count;                 
            return count;
        }

        public IEnumerable<IGrouping<string, Nanny>> NanniesByAge(bool Sort=false)
        {
            if (Sort)
            {
                IEnumerable<IGrouping<string, Nanny>> Result = (from nan in getAllNannys()
                                                                orderby nan.RangeAge
                                                                group nan by nan.RangeAge).ToList();
                return Result;
            }
            else
            {
                IEnumerable<IGrouping<string, Nanny>> Result = (from nan in getAllNannys()
                                                                group nan by nan.RangeAge).ToList();
                return Result;
            }
                
        }

        public IEnumerable<IGrouping<string, Nanny>> NannyByCity(bool flag = false)
        {
            if (flag)
                return
                from n in getAllNannys()
                orderby n.Address.City
                group n by n.Address.City into g
                select g;
            return
                from n in getAllNannys()
                group n by n.Address.City into g
                select g;
        }

        public IEnumerable<IGrouping<string, Nanny>> NannyByStreet(bool flag = false)
        {
           
            if (flag)
                return
                from n in getAllNannys()
                orderby n.Address.Street
                group n by n.Address.Street into g
                select g;
            return
                from n in getAllNannys()
                group n by n.Address.Street into g
                select g;
        }

        public IEnumerable<IGrouping<int, Nanny>> NannyByAgeMin_Max(bool minimum)
        {
            if(minimum==false)
              return
              from n in getAllNannys()
              orderby n.MinChildAge
              group n by (n.MinChildAge) into g
              select g;
            return
                from n in getAllNannys()
                orderby n.MaxChildAge
                group n by (n.MaxChildAge) into g
                select g;

        }

        public IEnumerable<IGrouping<double,Contract>> ContractByDistance(bool Sort = false)
        {
          
            if (Sort)
                return
                from c in getAllContracts()
                let dis = Distance(getAllNannys().Find(N => N.ID == c.NannyID).Address.ToString(),getAllMothers().Find(M => M.ID == c.MotherID).Address.ToString())
                orderby dis
                group c by (dis) into distance
                select distance;   
            return
                from c in getAllContracts()
                let dis = Distance((getAllNannys().Find(N => N.ID == c.NannyID)).Address.ToString(), (getAllMothers().Find(M => M.ID == c.MotherID)).Address.ToString())
                group c by (dis) into distance
                select distance;
        }

        //public Mother getMotherById(string m_id)
        //{
        //    Mother result = null;
        //    result = (from m in FactoryDal.getDal().getAllMothers()
        //              where m.ID == m_id
        //              select m).FirstOrDefault();
        //    return result;
        //}
    }
}
