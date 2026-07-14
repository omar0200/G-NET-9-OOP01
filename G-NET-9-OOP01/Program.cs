using System.Diagnostics;
using System.Net.Sockets;
using G_NET_9_OOP01;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace G_NET_9_OOP01
{
    public class Program
    {
        static void Main(string[] args)

        {
            #region Question 1
            ////struct

            //X x1 = new X();
            //x1.a = 10;
            //x1.b = 20;
            //X x2 = new X();
            //x2 = x1;
            //x2.a = 30;

            ////class
            //Y y1 = new Y();
            //y1.a = 10;
            //y1.b = 20;
            //Y y2 = new Y();
            //y2 = y1;
            //y2.a = 30;


            //Console.WriteLine($"x1: {x1.a}, {x1.b}");
            //Console.WriteLine($"x2: {x2.a}, {x2.b}");
            //Console.WriteLine($"y1: {y1.a}, {y1.b}");
            //Console.WriteLine($"y2: {y2.a}, {y2.b}");
            //struct assign values meanwhile class assign reference,
            //so when we change the value of x2.a it does not affect x1.a but when we change the value of y2.a it affects y1.a because they are reference type.
            #endregion

            #region Question 2
            //Y y3 = new Y(); 
            //Console.WriteLine($"y3: {y3.a}, {y3.b}, {y3.c} ");
            //we cannot access the private member c of class Y, so we will get an error if we try to access it.
            #endregion

            #region Question 3
            //open new project as class library and add reference to it in this project, then we can create an instance of the class in the class library and access its members.
            #endregion
            #region Question 4
            //A class library is a project in C# that contains reusable classes, and methods without a Main()
            //method so it does not run by itself, we use it for Code Reusability 
            #endregion

            #region Question 5

            Console.Write("Movie Name: ");
            string movie = Console.ReadLine();

            Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine());

            Console.Write("Seat Row: ");
            char row = char.Parse(Console.ReadLine());

            Console.Write("Seat Number: ");
            int number = int.Parse(Console.ReadLine());

            Console.Write("Price: ");
            int price = int.Parse(Console.ReadLine());

            Ticket ticket = new Ticket(movie, type, new Seat(row, number), price);

            Console.Write("Tax Percentage (e.g. 0.14): ");
            double tax = double.Parse(Console.ReadLine());

            Console.Write("Discount: ");
            double discount = double.Parse(Console.ReadLine());

            ticket.ApplyDiscount(discount);

            Console.WriteLine();
            Console.WriteLine("===== Ticket =====");
            ticket.PrintTicket();

            Console.WriteLine($"Total After Tax = {ticket.CalcTotal(tax)}");
            #endregion


        }
    }
  
}