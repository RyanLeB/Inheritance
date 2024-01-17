using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Player : Entity // reads: Player inherits GameObject
    {
        

        public int xp;
        public int level;
        public int score;

        public Player()
        {

            Console.WriteLine("Player class constructed");
            // instantiate health system
            healthSystem = new HealthSystem();

        }
        // ...
        // ...
        // ...
        // ...


    }
}
