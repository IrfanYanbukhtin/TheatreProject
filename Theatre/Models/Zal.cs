using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theatre.Models
{
    internal class Zal : Entity
    {
        internal int[,] Seats { get; set; } = new int[10, 10];
        internal void PrintSeats()
        {
            int RowCount = 0;
            int[,] seats = new int[10, 10];
            Console.WriteLine("     ");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}");
            }

            Console.WriteLine();

            for (int row = 0; row < 10; row++)
            {
                Console.Write($"{row + 1,-3}");

                for (int column = 0; column < 10; column++)
                {
                    Console.Write($"{seats[row, column] = 0}");
                }

                Console.WriteLine();
            }
        }

        public override string ToString()
        {
            Console.WriteLine("Seats\n");
            PrintSeats();
            return $"{Id}  {Name}";
        }
    }
}
