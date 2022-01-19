using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Models
{
    internal class HarryPotterHead : LegoHeadBase
    {
        public HarryPotterHead()
        {
            Theme = "Harry Potter";
        }
        public string House { get; set; }
        public string School { get; set; }

        public void Speak()
        {
            Console.WriteLine($"My color is {Color}.");
        }
    }
}
