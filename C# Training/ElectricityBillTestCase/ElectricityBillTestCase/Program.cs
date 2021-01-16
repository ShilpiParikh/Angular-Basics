using System;

namespace ElectricityBillTestCase
{
    public class Program
    {
        public void GetUserData()
        {
            int customerID, customerUnit;
            double charge = 0, surcharge = 0, gramt, netamount;
            string customerName;

            Console.Write("\n");
            Console.Write("Calculating Electricity Bill-->\n");

            Console.Write("Enter Customer ID: \n");
            customerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the Customer Name: \n");
            customerName = Console.ReadLine();
            Console.Write("Enter the units consumed by this Customer: \n");
            customerUnit = Convert.ToInt32(Console.ReadLine());

            if (customerUnit < 200)
                charge = 1.20;
            else if (customerUnit >= 200 && customerUnit < 400)
                charge = 1.50;
            else if (customerUnit >= 400 && customerUnit < 600)
                charge = 1.80;
            else if (customerUnit >= 600)
                charge = 2.00;
            gramt = customerUnit * charge;

            if (gramt > 400)
                surcharge = gramt * 15 / 100.0;
            netamount = gramt + surcharge;
            if (netamount < 100)
                netamount = 100;

            Console.WriteLine("Customer ID: {0}", customerID);
            Console.WriteLine("Customer Name: {0}", customerName);
            Console.WriteLine("Customer Units consumed: {0}", customerUnit);
            Console.WriteLine("Amout Charges @Rs. {0} per unit : {1}", charge, gramt);
            Console.WriteLine("Surface Amont: {0}", surcharge);
            Console.WriteLine("Net Amount to be paid by Customer : {0}", netamount);
        }
        
    }
}
