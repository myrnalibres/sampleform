using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter4
{
    public class Personnel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        private string _position;

        public string Position
        {
            get { return _position; }
            set
            {
                _position = value;

                SetGrossPay(_position);


                //At this Point the Gross Pay has been updated
                //SetHazardPay();

                //SetLongPay(HireDate);
                SetDeductions();
                SetAllowances();
                SetTotalSalary();

            }
        }


        public double GrossPay { get; private set; }

        private DateTime hireDate;

        public DateTime HireDate
        {
            get { return hireDate; }
            set
            {
                hireDate = value;


                SetLongPay(hireDate);

            }
        }

        
        public double LongPay { get; private set; }

        public double HazardPay { get; private set; }
        public double ClothingAllowance { get; private set; }
        public double LaundryAllowance { get; private set; }
        public double TotalAllowances { get; private set; }

        public double Sss { get; private set; }
        //private double sgti;
        public double GSIS { get; set; }
        public double PhilHealth { get; private set; }
        public double Tax { get; private set; }
        //private double pagIbig;
        //private double equityPlan;
        public double TotalDeductions { get; private set; }
        public double TotalSalary { get; private set; }


        public Personnel(string firstName = "Juan", string lastName = " Dela Cruz", string position = "PO1")
        {
            //Default HireDate is when creating an instane of the object
            HireDate = DateTime.Now;
            FirstName = firstName;
            LastName = lastName;
            Position = position;

        }

        //METHODS
        private void SetLongPay(DateTime hireDate)
        {
            int YearsOfService = DateTime.Now.Year - hireDate.Year;


            switch (Position)
            {

                case "PO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1483.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 4910.00;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 6884.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 7417.00;
                        }
                        break;


                        //Continue the Else If

                    }

                case "PO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5605.00;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 7859.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 8467.00;
                        }
                        break;

                        ;
                    }

                case "PO3":
                    {
                        if (YearsOfService >= 15 && YearsOfService < 10)
                        {
                            LongPay = 1867.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3920.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 6178.00;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 8662.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 9333.00;
                        }
                        break;


                    }

                case "SPO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 2171.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 4559.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 7186;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 10076.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 10856.00;
                        }
                        break;
                    }


                case "SPO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }

                case "SPO3":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }


                case "SPO4":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }

                case "PINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }
                case "PSINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }
                case "PCINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }
                case "PSUPT":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            LongPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            LongPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            LongPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            LongPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            LongPay = 3115.00;
                        }
                        break;
                    }

                default:
                    break;
            }

        }

        private void SetGrossPay(string position)
        {

            switch (position)
            {
                case "PO1":
                    {
                        GrossPay = 14834.00;
                        break;
                    }

                case "PO2":
                    {
                        GrossPay = 16934.00;
                        break;
                    }

                case "PO3":
                    {
                        GrossPay = 18665.00;
                        break;
                    }

                case "SPO1":
                    {
                        GrossPay = 21711.00;
                        break;
                    }
                case "SPO2":
                    {
                        GrossPay = 23513.00;
                        break;
                    }

                case "SPO3":
                    {
                        GrossPay = 25394.00;
                        break;
                    }
                case "SPO4":
                    {
                        GrossPay = 27425.00;
                        break;
                    }

                case "PINSP":
                    {
                        GrossPay = 14834.00;
                        break;
                    }
                case "PSINSP":
                    {
                        GrossPay = 14834.00;
                        break;
                    }

                case "PCINSP":
                    {
                        GrossPay = 14834.00;
                        break;
                    }
                case "PSUPT":
                    {
                        GrossPay = 14834.00;
                        break;
                    }

            }
        }

        //private void SetHazardPay()
        //{
        //    hazardPay = 240;
        //}

        ////Getting the LongPay where LongPay is not a property, a user can set
        //public double GetLongPay()
        //{
        //    return longPay;
        //}
        //public double GetHazardPay()
        //{
        //    return hazardPay;
        //}

        private void SetAllowances()
        {
            HazardPay = Allowances.GetHazardPay(GrossPay);
            ClothingAllowance = Allowances.GetClothingAllowance(GrossPay);
            LaundryAllowance = Allowances.GetLaundryAllowance(GrossPay);
            TotalAllowances = HazardPay + ClothingAllowance + LaundryAllowance;
             
        }
        private void SetDeductions()
        {
            Sss = Deductions.GetSss(GrossPay);
            Tax = Deductions.GetTax(GrossPay);
            PhilHealth = Deductions.GetPhilHealth(GrossPay);
            //PagIbig = Deductions.GetPagIbig(GrossPay);
            TotalDeductions = Sss + Tax + PhilHealth;
            //Sgti = Deductions.GetSgti(GrossPay);
            //EquityPlan = Deductions.GetEquityPlan(GrossPay);
        }
        private void SetTotalSalary()
        {
            TotalSalary = GrossPay + LongPay - TotalDeductions;
        }
    }
}

        





//        //Getting the GrossPay where GrossPay is not a property, a user can set
//        public double GetGrossPay()
//        {
//            return grossPay;
//        }

//        private void SetDeductions()
//        {
            
           
//        }


        

//        public double GetTax()
//        {
//            return tax;
//        }

//        public double GetPhilHealth()

//        {
//            return philHealth;
//        }
//        public double GetPagibig()
//        {
//            return pagIbig;
//        }
//         public double GetSgti()
//        {
//            return sgti;
//        }
        
//        public double GetEquityPlan()
//        {
//            return equityPlan;
//        }

//        public double GetTotalSalary()
//        {
//            double TotalSalary = 0;
            

//            TotalSalary = GrossPay + LongPay+ HazardPay - Deductions.GetTotalDeductions(GrossPay);

//            return TotalSalary;
//        }





























//    }
//}




//    }
//}
