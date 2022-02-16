using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public static class Class1
    {
          public static bool RecargaIsOk(double depMoney)
        {
        if (depMoney == 0 || depMoney < 0)
        {

            return false;
        }
        return true;
    
        }

    }

