using LegoMinifigures.Models
;
using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Batman batman1 = new Batman()
            {
                Accessories = "belt",
                Hat = "mask",
                Torso = "ripped"
            };

            Chef chef1 = new Chef();
            Pirate pirate1 = new Pirate();

            chef1.Accessories = "spatula";
            chef1.Hat = "white chef hat";
            chef1.Torso = "covered in sauce";

            pirate1.Accessories = "sword";
            pirate1.Hat = "black pirate hat";
            pirate1.Torso = "battlescarred";

            //Console.WriteLine($"Batman has a {batman1.Accessories} and a {batman1.Hat} and is {batman1.Torso}.");
            //Console.WriteLine($"The chef has a {chef1.Accessories} and a {chef1.Hat} and is {chef1.Torso}.");
            //Console.WriteLine($"THe pirate has a {pirate1.Accessories} and a {pirate1.Hat} and is {pirate1.Torso}.");


            //batman1.Threaten();
            //chef1.ThrowSpatula();
            //pirate1.Hobble();

            Console.WriteLine("What type of head do you want? ");

            string response = Console.ReadLine();

            var jackSparrow = new PirateHead();
            var ronWeasley = new HarryPotterHead();

            jackSparrow.Color = LegoColor.Yellow;
            ronWeasley.Color = LegoColor.Gray;

            ronWeasley.Speak();
            //can loop over an enum for a dropdown for user options
        }
    }
}
