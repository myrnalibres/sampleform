using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PNP_Salary
{

    public class Employee
    {
        public string Name { get; set; }

        private string position;

        public string Position
        {
            get { return position; }
            set
            {
                position = value;

                SetGrossPay(position);


                //At this Point the Gross Pay has been updated
                SetHazardPay();

                SetLongPay(HireDate);
                SetDeductions();
            }
        }


        private double grossPay;

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

        private double longPay;
        private double hazardPay;

        private double sgti;
        private double philHealth;
        private double tax;
        private double pagIbig;
        private double equityPlan;


        public Employee(string name = "Juan Dela Cruz", string position = "PO1")
        {
            //Default HireDate is when creating an instane of the object
            HireDate = DateTime.Now;
            Name = name;
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
                            longPay = 1483.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 4910.00;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 6884.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 7417.00;
                        }
                        break;


                        //Continue the Else If

                    }

                case "PO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5605.00;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 7859.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 8467.00;
                        }
                        break;

                        ;
                    }

                case "PO3":
                    {
                        if (YearsOfService >= 15 && YearsOfService < 10)
                        {
                            longPay = 1867.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3920.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 6178.00;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 8662.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 9333.00;
                        }
                        break;


                    }

                case "SPO1":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 2171.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 4559.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 7186;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 10076.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 10856.00;
                        }
                        break;
                    }


                case "SPO2":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
                        }
                        break;
                    }

                case "SPO3":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
                        }
                        break;
                    }


                case "SPO4":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
                        }
                        break;
                    }

                case "PINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
                        }
                        break;
                    }
                case "PSINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
                        }
                        break;
                    }
                case "PCINSP":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
                        }
                        break;
                    }
                case "PSUPT":
                    {
                        if (YearsOfService >= 5 && YearsOfService < 10)
                        {
                            longPay = 1693.00;
                        }
                        else if (YearsOfService >= 10 && YearsOfService < 15)
                        {
                            longPay = 3556.00;
                        }
                        else if (YearsOfService >= 15 && YearsOfService < 20)
                        {
                            longPay = 5433;
                        }

                        else if (YearsOfService >= 20 && YearsOfService < 25)
                        {
                            longPay = 3115.00;
                        }
                        else if (YearsOfService >= 25)
                        {
                            longPay = 3115.00;
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
                        grossPay = 14834.00;
                        break;
                    }

                case "PO2":
                    {
                        grossPay = 16934.00;
                        break;
                    }

                case "PO3":
                    {
                        grossPay = 18665.00;
                        break;
                    }

                case "SPO1":
                    {
                        grossPay = 21711.00;
                        break;
                    }
                case "SPO2":
                    {
                        grossPay = 23513.00;
                        break;
                    }

                case "SPO3":
                    {
                        grossPay = 25394.00;
                        break;
                    }
                case "SPO4":
                    {
                        grossPay = 27425.00;
                        break;
                    }

                case "PINSP":
                    {
                        grossPay = 14834.00;
                        break;
                    }
                case "PSINSP":
                    {
                        grossPay = 14834.00;
                        break;
                    }

                case "PCINSP":
                    {
                        grossPay = 14834.00;
                        break;
                    }
                case "PSUPT":
                    {
                        grossPay = 14834.00;
                        break;
                    }



                default:
                    break;
            }
        }

        private void SetHazardPay()
        {
            hazardPay = 240;
        }

        //Getting the LongPay where LongPay is not a property, a user can set
        public double GetLongPay()
        {
            return longPay;
        }
        public double GetHazardPay()
        {
            return hazardPay;
        }
        //Getting the GrossPay where GrossPay is not a property, a user can set
        public double GetGrossPay()
        {
            return grossPay;
        }

        private void SetDeductions()
        {
            
            tax = Deductions.GetTax(grossPay);
            philHealth = Deductions.GetPhilHealth(grossPay);
            pagIbig = Deductions.GetPagIbig(grossPay);
            sgti = Deductions.GetSgti(grossPay);
            equityPlan = Deductions.GetEquityPlan(grossPay);
        }


        

        public double GetTax()
        {
            return tax;
        }

        public double GetPhilHealth()

        {
            return philHealth;
        }
        public double GetPagibig()
        {
            return pagIbig;
        }
         public double GetSgti()
        {
            return sgti;
        }
        
        public double GetEquityPlan()
        {
            return equityPlan;
        }

        public double GetTotalSalary()
        {
            double totalSalary = 0;
            

            totalSalary = grossPay + longPay+ hazardPay - Deductions.GetTotalDeductions(grossPay);

            return totalSalary;
        }





























    }
}
