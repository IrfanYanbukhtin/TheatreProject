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
        internal string StartTime { get; set; }
        internal string EndTime { get; set; }

        internal Zal Zal { get; set; }
        internal Film Film { get; set; }

        public override string ToString()
        {
            return $"{Id} {Film}\n{Zal}\n{StartTime}\n{EndTime}";
        }

      
    }
}
