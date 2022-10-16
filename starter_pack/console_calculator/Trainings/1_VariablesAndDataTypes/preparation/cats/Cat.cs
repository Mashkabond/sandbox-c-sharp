using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator.Trainings._1_VariablesAndDataTypes.preparation.cats
{
    internal class Cat : Animal
    {

        public string Breed { get; set; }
        public Dog dog { get; set; }

        public override void Say()
        {
            Console.WriteLine("Кот мяукает");
        }
    }
}
