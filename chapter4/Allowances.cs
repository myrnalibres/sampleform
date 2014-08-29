using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    public class Allowances
    {
        public static double GetTotalAllowances(double GrossPay)
        {
            double TotalAllowances = GetHazardPay(GrossPay) + GetClothingAllowance(GrossPay) + GetLaundryAllowance(GrossPay);

            return TotalAllowances;
        }

        public static double GetHazardPay(double GrossPay)
        {
            //DO Tax Computation
            return 240;
        }

        public static double GetClothingAllowance(double GrossPay)
        {
            //DO Tax Computation
            return 200;
        }

        public static double GetLaundryAllowance(double GrossPay)
        {
            double LaundryAllowance = 0;

            if (GrossPay <= 27425)
            {
                LaundryAllowance = 30;
            }

            else if (GrossPay >=27426)
            {
                LaundryAllowance = 60;
            }

                return LaundryAllowance;
        }

    }
}
