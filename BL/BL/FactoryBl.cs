using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using BL;

namespace BL
{
    public class FactoryBl
    {
        private static Ibl instance = null;

        public static Ibl getBL()
        {
            if (instance == null)
            {
                instance = new BL_imp();
            }
            return instance;
        }

    }
}
