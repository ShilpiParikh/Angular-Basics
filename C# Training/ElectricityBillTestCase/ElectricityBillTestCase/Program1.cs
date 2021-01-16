using System;
using System.Collections.Generic;
using System.Text;

namespace ElectricityBillTestCase
{
   public class Program1
    {
        int customerID;
        double charge = 0, customerUnit, surcharge = 0, gramt, netamount;
        string customerName;
        public void GetUserData()
        {
            
            Console.Write("\n");
            Console.Write("Calculating Electricity Bill-->\n");
            Console.Write("Enter Customer ID: \n");
            customerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Customer Name: \n");
            customerName = Console.ReadLine();
            Console.Write("Enter the units consumed by this Customer: \n");
            customerUnit = Convert.ToInt32(Console.ReadLine());
            double returnCharge = checkUnits(customerUnit);
            double returnGramt = calculateGramt(returnCharge, customerUnit);
            double returnSurcharge = calculateSurCharge(returnGramt);
            double returnNetamout = calculateTotalAmount(returnSurcharge, returnGramt);
            if(customerUnit >= 0)
                displayDetails(customerID, customerName, customerUnit, returnCharge, returnGramt, returnSurcharge, returnNetamout);
            else
                Console.WriteLine("Customer Unit cannot be negative");

        }

        public double checkUnits(double customerUnit)
        {
            if(customerUnit < 0)
            {
                
                charge = 0;
            }
            else if (customerUnit < 200)
                charge = 1.20;
            else if (customerUnit >= 200 && customerUnit < 400)
                charge = 1.50;
            else if (customerUnit >= 400 && customerUnit < 600)
                charge = 1.80;
            else
                charge = 2.00;
            return charge;
        }

        public double calculateGramt(double charge, double customerUnit)
        {
            gramt = customerUnit * charge;
            return gramt;
        }
        public double calculateSurCharge(double gramt)
        {
            if (gramt > 400)
                surcharge = gramt * 15 / 100.0;
            return surcharge;
            
        }

        public double calculateTotalAmount(double surchrge, double gramt)
        {
            netamount = gramt + surcharge;
            if (netamount < 100)
                return netamount = 100;
            else
                return netamount;
        }

        public void displayDetails(int customerID, string customerName, double customerUnit, double charge, double gramt, double surcharge, double netamount)
        {
            Console.WriteLine("Customer ID: {0}", customerID);
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Customer Units consumed: {0}", customerUnit);
            Console.WriteLine("Amout Charges @Rs. {0} per unit : {1}", charge, gramt);
            Console.WriteLine("Surface Amont: {0}", surcharge);
            Console.WriteLine("Net Amount to be paid by Customer : {0}", netamount);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("***** Electricity Bill Calculation *****");
            Program1 basicIO = new Program1();
            basicIO.GetUserData();

            Console.ReadLine();

        }
    }
}
