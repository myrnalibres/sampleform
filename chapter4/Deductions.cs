using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    public class Deductions
    {


        public static double GetTotalDeductions(double GrossPay)
        {
            double TotalDeductions = GetPhilHealth(GrossPay) + GetTax(GrossPay) + GetSss(GrossPay);

            return TotalDeductions;
        }


        //public static double GetPagIbig(double grossPay)
        //{
        //    //EDIT


        //    return 100;
        //}

        public static double GetPhilHealth(double GrossPay)
        {
            //DO Logic for PhilHealth
            double PhilHealth = 0;

            if (GrossPay >= 14000 && GrossPay < 15000)
            {
                PhilHealth = 162.50;
            }

            else if (GrossPay >= 15000 && GrossPay < 16000)
            {
                PhilHealth = 175.00;
            }

            else if (GrossPay >= 16000 && GrossPay <= 170000)
                PhilHealth = 187.50;

            return PhilHealth;
        }



        public static double GetTax(double GrossPay)
        {
            //DO Tax Computation
            double Tax = 0;
            Tax = GrossPay * 0.12;

            return Tax;
        }
        //public static double GetSgti(double grossPay)
        //{
        //    //DO Tax Computation
        //    return 6;
        //}

        //public static double GetEquityPlan(double grossPay)
        //{
        //    return 32;

        //}

        public static double GetSss(double GrossPay)
        {
            return 100;

        }

    }
}
