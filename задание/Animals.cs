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
        

        public Animals(string name, int age, string species, string biome, double areaPerIndividual, string[] diet, string sound)
        {
            Name = name;
            Age = age;
            Species = species;
            Biome = biome;
            SquareArea = areaPerIndividual;
            Diet = diet;
            Sound = sound;
        }
       
        public string Eat(string food)
        {
            bool result = false;

            for( int i= 0; i< Diet.Length; i++ )
            {
                result = result || (Diet[i] == food);
            }

            if(result == true)    
            {
                return  $"Животное {Name} ест {food}";
            }
            else
            {
                return $"Животное {Name} не ест {food}";
            }
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
