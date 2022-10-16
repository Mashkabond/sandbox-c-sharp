using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console_calculator.Trainings._1_VariablesAndDataTypes.preparation.cats
{
    internal abstract class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public abstract void Say();
    }
}
