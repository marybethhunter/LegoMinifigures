using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures.Figures
{
    class Batman
    {
        public string Hat { get; set; }
        public string Torso { get; set; }
        public string Accessories { get; set; }

        public void Threaten()
        {
            Console.WriteLine("Watch out, I'm Batman!");
        }

        public void Batmobile()
        {
            Console.WriteLine("Batman gets into the Batmobile and accelarates towards the target.");
        }
    }
}
