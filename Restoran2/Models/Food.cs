using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran2.Models
{
    public class Food
    {
        public string? Name { get; set; }
        public double Price { get; set; }


        public Food(string? name, double price)
        {
            Name = name;
            Price = price;
        }

        public Food()
        {

        }

        public override string ToString() => $@"{Name}     {Price}";

    }
}
