using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP4_Reuse_OPP2
{
    public static class YourUntils
    {
        public static int Tuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Birthday.Year;
        }

        public static Boolean CheckSinhNhat(this Employee emp) 
        { 
            if(emp.Birthday.Month == DateTime.Now.Month)
            {
                return true;
            }else
                return false;
        }
    }
}
