using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AnimalsTask
{
    public class Animals
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Species { get; set; }
        public string Biome { get; set; }
        public double SquareArea { get; set; }
        public string[] Diet { get; set; }
        public string Sound { get; set; }

        public void Eat()
        {
            Console.WriteLine($"Животное {Name} ест");
        }

        public void MakeSound()
        {
            Console.WriteLine($"Животное {Name} издает звук: {Sound}");
        }

        public void Play()
        {
            Console.WriteLine($"Животное {Name} играет");
        }
    }
}
