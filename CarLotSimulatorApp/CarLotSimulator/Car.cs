using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarLotSimulator
{
    //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable
    //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise()
    //The methods should take one string parameter: the respective noise property
    public class Car
    {
      public int year { get; set; }
      public string make { get; set; }
      public string model { get; set; }
      public string EngineNoise { get; set; }
     public string  HonkNoise { get; set; }
     public bool isDriveable { get; set; }

        public void MakeEngineNoise(string noise)
        {
            Console.WriteLine($" the {make} engine goes {noise}");
        }
        public void MakeHonkNoise(string honk)
        {
            Console.WriteLine($" the horn sounds like {honk}");
        }

    }
}
