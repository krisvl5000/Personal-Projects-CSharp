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

        public override void Attack(IItem weapon, IPlayer enemy)
        {
            if (Inventory.Contains(weapon))
                enemy.Health -= weapon.Damage;

            else
            {
                throw new InvalidWeaponException
                    (ExceptionMessages.INVALID_WEAPON_MESSAGE);
            }
        }

        public override void Block(IItem shield, IPlayer enemy)
        {
            if (Inventory.Contains(shield))
            {
                
            }
        }

        public override void Sell(IItem item)
        {
            throw new NotImplementedException();
        }
    }
}
