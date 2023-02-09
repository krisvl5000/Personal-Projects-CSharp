using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest
{
    public class MainPlayer : Player
    {
        public MainPlayer(string name) : base(name)
        {
            Inventory = new HashSet<IItem>();
        }

        public override ICollection<IItem> Inventory { get; set; }

        void AddItem(IItem item)
        {
            Inventory.Add(item);
        }
    }
}
