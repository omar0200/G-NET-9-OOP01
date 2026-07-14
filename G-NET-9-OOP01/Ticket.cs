using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace G_NET_9_OOP01
{
   public class Ticket
    {
        private int _price;
        public Seat _Seat { get; set; }
        public TicketType _type { get; set; }
        public string _MovieName { get; set; }

        public Ticket(string movieName, TicketType type, Seat seat, int price)
        {
           _MovieName = movieName;
            _type = type;
            _Seat = seat;
            _price = price;
        }

        public Ticket(string movieName) : this(movieName, TicketType.Standard, new Seat('A', 1), 50)
        { }

        public double CalcTotal(double taxPercent)
        {
            double total = taxPercent* (double)_price +(double)_price;
            return total;
        }

        public double ApplyDiscount(double discountAmount)
        {
            if (discountAmount > 0 &&  discountAmount < _price)
            {
                _price = _price - (int)discountAmount;
                discountAmount = 0;
                return _price;
            }
            else
            {
                Console.WriteLine("Discount Is Not Valid!");
                    
                return _price;
            }
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Movie Name is : {_MovieName} || Ticket Type {_type} " +
                $"|| Seat {_Seat} || Price : {_price} ");
        }


        public override string ToString()
            => $"{_MovieName} | {_type} | Seat {_Seat} | Price {_price}";

    }
}
