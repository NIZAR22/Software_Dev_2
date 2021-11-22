using System;

namespace ZooApplication
{
    public class DoMain
    {
        // declarations
        string adultQty;
        string firstName;
        string lastName;
        int childQty;
        double adultPrice = 18.00;
        double childPrice = 10.00;
        double adultCost;
        double childCost;
        double totalCost;
        /// <summary>
        /// main method that will execute other methods
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Welcome();
            GetTicket();
            
            //todo get this line of code to work
            //ShowTicketCost(adultCost, adultQty, childCost, childQty);
            //Console.WriteLine("Your total is " + );
            Console.WriteLine("The adult tickets will cost you $18.00 ");
            Console.WriteLine("The child tickets will cost you $10.00 ");
            Exit();
            Console.WriteLine("Thank you for puchasing your tickets! Have a great day at the Zoo!");
        }

        /// <summary>
        /// displays welocome text
        /// </summary>
        private static void Welcome()
        {
            Console.WriteLine("WELCOME TO THE ZOO!");
        }
        /// <summary>
        /// will get ticket quantity from user
        /// </summary>
        private static void GetTicket()
        {
            Console.WriteLine("Please choose the amount of tickets you want below: ");
            Console.WriteLine();
            Console.WriteLine("Adult ticket amount: ");
            var adultQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Child ticket amount: ");
            var childQty = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

        }
        /// <summary>
        /// Will calculate adult ticket price
        /// </summary>
        /// <param name="adultQty"></param>
        /// <param name="adultPrice"></param>
        /// <returns></returns>
        public double CalculateAdultPrice(int adultQty, double adultPrice)
        {
            var adultCost = adultPrice * adultQty;
            return adultCost;
        }
        /// <summary>
        /// Will calculate child ticket price
        /// </summary>
        /// <param name="childQty"></param>
        /// <param name="childPrice"></param>
        /// <returns></returns>
        public double CalculateChildPrice(int childQty, double childPrice)
        {
            var childCost = childPrice * childQty;
            return childCost;
        }
        /// <summary>
        /// Will print ticket price based on user input
        /// </summary>
        /// <param name="adultCost"></param>
        /// <param name="adultQty"></param>
        /// <param name="childCost"></param>
        /// <param name="childQty"></param>
        public double ShowTicketCost(double adultCost, double childCost, double totalCost)
        {
            var total = adultCost + childCost;
            //if (adultCost != null)
            //{
            //    var total = adultCost + childCost;
            //    //var AdultCostCurrency = String.Format("{0:C}", Convert.ToInt32(adultCost));
            //    //Console.WriteLine("The adult tickets will cost you " + AdultCostCurrency + " .");
            //}
            
            //else
            //{
            //    Console.WriteLine("No ticket quantity entered. Please enter ticket quantity to continue. ");
            //    GetTicket();
            //}
            return totalCost;
        }
        /// <summary>
        /// will exit the console upon key entry.
        /// </summary>
        private static void Exit()
        {
            Console.WriteLine("Press any key to exit console.");
            Console.ReadKey();
        }
    }
}
