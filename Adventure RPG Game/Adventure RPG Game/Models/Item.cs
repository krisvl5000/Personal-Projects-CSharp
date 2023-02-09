using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest
{
    public abstract class Item : IItem
    {
        public Item(string name, int price, int damage)
        {
            Name = name;
            Price = price;
            Damage = damage;
        }

        public string Name { get; set; }

        public int Price {get; set; }

        public int Damage {get; set; }
    }
}
