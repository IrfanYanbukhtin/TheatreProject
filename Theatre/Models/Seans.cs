using Core.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre.Models
{
    internal class Seans : Entity
    {
        internal DateTime StartTime { get; set; }
        internal DateTime EndTime { get; set; }

        internal string Zal { get; set; }
        internal string Film { get; set; }

        public override string ToString()
        {
            return $"{Id} {Film}\n{Zal}\n{StartTime}\n{EndTime}";
        }

      
    }
}
