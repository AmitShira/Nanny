using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
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
   public interface Ibl
    {

        void AddNanny(Nanny nanny);
        void DeleteNanny(Nanny nanny);
        void UpdateNanny(Nanny nanny);

        void AddMother(Mother mother);
        void DeleteMother(Mother mother);
        void UpdateMother(Mother mother);

        void AddChild(Child child);
        void DeleteChild(Child child);
        void UpdateChild(Child child);

        void AddContract(Contract contract);
        void DeleteContract(Contract contract);
        void UpdateContract(Contract contract);

        int NannySalary( Nanny nanny);
        int MotherPayment(Mother mother);
        List<Nanny> Potential_Nanny(Child child, Mother mother);
       
        List<Child> NannyLessChldrn();
        List<Nanny> Tamat_Vacation();
        List<Contract> ConditionContract(Predicate<Contract> condition );
        int ConditionNumberContract(Predicate<Contract> condition);
        IEnumerable<IGrouping<string, Nanny>> NanniesByAge(bool Sort=false);
        IEnumerable<IGrouping<string, Nanny>> NannyByCity(bool flag = false);
        IEnumerable<IGrouping<string, Nanny>> NannyByStreet(bool flag = false);
        IEnumerable<IGrouping<int, Nanny>> NannyByAgeMin_Max(bool minimum = false);
        IEnumerable<IGrouping<double,Contract>> ContractByDistance(bool Sort=false);


        List<Nanny> getAllNannys(Predicate<Nanny> condition = null);
        List<Mother> getAllMothers(Predicate<Mother> condition = null);
        List<Child> getAllChilds(Predicate<Child> condition = null);
        List<Contract> getAllContracts();
        List<Child> getAllChildsByMother(Mother mother);
        List<BankAccount> getAllBankBranches();
      //  Mother getMotherById(string v);
    }
}
