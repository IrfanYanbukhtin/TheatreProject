using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre.Models
{
    internal class Film : Entity
    {
        public override string ToString()
        {
        
            return $"{Name}";
        }

        public static implicit operator string(Film v)
        {
            throw new NotImplementedException();
        }
    }
}
