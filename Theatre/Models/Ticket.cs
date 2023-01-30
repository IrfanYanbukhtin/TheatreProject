using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre.Models
{
    internal class Ticket : Entity
    {

        public int Quantity { get; set; } = 1;
        
        internal string Zal { get; set; }
        internal string Seans { get; set; }

        public override string ToString()
        {
            return $"{Zal}\n{Seans}";
        }


    }
}
