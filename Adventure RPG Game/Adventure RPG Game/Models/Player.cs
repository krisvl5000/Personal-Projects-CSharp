using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest
{
    public abstract class Player : IPlayer
    {
        public Player()
        {
            Inventory = new HashSet<IItem>();
        }

        public Player(string name) : this()
        {
            Name = name;
            Health = 100;
        }

        private string name;

        public string Name
        {
            get { return name; }

            private set 
            { 
                if (string.IsNullOrEmpty(value))
                {
                    throw new InvalidPlayerNameException
                    (String.Format(ExceptionMessages.INVALID_PLAYER_NAME_MESSAGE));
                }
                name = value; 
            }
        }

        public IItem MainWeapon { get; set; }

        public int Health { get; set; }

        public int Money { get; set; }

        public abstract ICollection<IItem> Inventory { get; set; }

        public abstract void Attack(IItem weapon, IPlayer enemy);

        public abstract void Block(IItem shield, IPlayer enemy);

        public abstract void Sell(IItem item);
    }
}
