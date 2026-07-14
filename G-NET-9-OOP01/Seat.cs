using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_NET_9_OOP01
{
    public struct Seat
    {
        public char row;
        public int number;

        public Seat(char row, int number)
        {
            this.row = row;
            this.number = number;
        }

        public override string ToString() => $"{row}{number}";
    }
}
