using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNP_Salary
{


    public static class Deductions
    {
        //Static Classes, use static Methods
        public static double GetTotalDeductions(double grossPay)
        {
            double totalDeductions = GetPagIbig(grossPay) + GetPhilHealth(grossPay) + GetTax(grossPay) + GetSgti(grossPay) + GetEquityPlan(grossPay);

            return totalDeductions;
        }


        public static double GetPagIbig(double grossPay)
        {
            //EDIT
            
        
            return 100;
        }

        public static double GetPhilHealth(double grossPay)
        {
            //DO Logic for PhilHealth
            double philHealth = 0;

            if (grossPay >= 14000 && grossPay < 15000)
            {
                philHealth = 162.50;
            }

            else if (grossPay >= 15000 && grossPay < 16000)
            {
                philHealth = 175.00;
            }

            else if (grossPay >= 16000 && grossPay <= 170000)
                philHealth = 187.50;

            return philHealth;
        }



        public static double GetTax(double grossPay)
        {
            //DO Tax Computation
            double Tax = 0;
            Tax = grossPay * 0.12;

            return Tax;
        }
        public static double GetSgti(double grossPay)
        {
            //DO Tax Computation
            return 6;
        }
        public static double GetEquityPlan(double grossPay)
        {
            return 32;

        }


    }

}














    

