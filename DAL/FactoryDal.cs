using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class FactoryDal
    {
        private static Idal instance = null;

        public static Idal getDal()
        {
            if (instance == null)
            {
                instance = new Dal_imp();
            }
            return instance;
        }



    }

}
