using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables_and_data_types
{
    internal class Cat
    {
        public string Name { get; set; }
        public string Poroda { get; set; }
        public string NomerMashini { get; set; }

        public void ChangeName(string newName) {
            Console.WriteLine("Мы изменяем имя кота на " + newName);
            Name = newName;
        }
    }
}
