using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Models
{
    class Pirate
    {
        public string Hat { get; set; }
        public string Torso { get; set; }
        public string Accessories { get; set; }

        public void Hobble()
        {
            Console.WriteLine("Hobbles around on peg leg.");
        }

        public void Fight()
        {
            Console.WriteLine("Sword is swung and nearly connects with its target.");
        }
    }
}
