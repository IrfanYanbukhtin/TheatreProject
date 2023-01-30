using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Theatre.Models
{
    internal class Teatr : Entity
    {
       internal Zal[] Zals { get; set; } = new Zal[0];


        public override string ToString()
        {
            string zals = "";
            foreach (var item in Zals)
            {
                if (item == null) continue;

                zals += item.ToString() + "\n";
            }
            return $"{Id} {Name} \nZals: {Zals}";


        }
    }
}
