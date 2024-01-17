using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Demo
{
    internal class Entity : GameObject
    {
        public HealthSystem healthSystem;
        

        public Entity() 
        {

            Console.WriteLine("Entity class constructed");
            // instantiate health system
            healthSystem = new HealthSystem();

        }

    }
}
