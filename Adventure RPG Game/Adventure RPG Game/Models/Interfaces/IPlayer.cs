using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest
{
    public interface IPlayer
    {
        string Name { get; }

        int Health { get; }

        Type Type { get; }

        ICollection<IItem> Inventory { get; }

        void Attack();

        void Block();

        void Sell();
    }
}
