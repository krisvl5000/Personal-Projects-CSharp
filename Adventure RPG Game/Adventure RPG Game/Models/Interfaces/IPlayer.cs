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

        int Health { get; set; }

        int Money { get; }

        IItem MainWeapon { get; set; }

        void Attack(IItem item, IPlayer enemy);

        void Block(IItem item, IPlayer enemy);

        void Sell(IItem item);
    }
}
