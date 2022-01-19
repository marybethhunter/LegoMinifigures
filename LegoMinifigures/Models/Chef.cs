using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Models
{
    class Chef
    {
        public string Hat { get; set; }
        public string Torso { get; set; }
        public string Accessories { get; set; }

        public void CookBurger()
        {
            Console.WriteLine("A wild burger appears.");
        }

        public void ThrowSpatula()
        {
            Console.WriteLine("Spatula is thrown across the room at the enemy.");
        }
    }
}
