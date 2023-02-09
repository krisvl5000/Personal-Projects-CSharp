using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chest
{
    public class Engine : IEngine
    {
        private readonly IReader reader;
        private readonly IWriter writer;

        private readonly ICollection<IItem> items;

        private Engine()
        {
            items = new HashSet<IItem>();
        }

        public Engine(IReader reader, IWriter writer) : this()
        {
            this.reader = reader;
            this.writer = writer;
        }

        public void Run()
        {
            IItem basicSword = new BasicSword("Basic Sword", 10, 50);
            IPlayer player = new MainPlayer("Main Player");
            IPlayer otherPlayer = new MainPlayer("Nekoi si tam");

            //otherPlayer.Health = 100;

            player.Attack(basicSword, otherPlayer);
            writer.WriteLine(otherPlayer.Health);
        }
    }
}
