using console_calculator.Trainings._1_VariablesAndDataTypes.preparation.cats;

namespace console_calculator.Trainings._1_VariablesAndDataTypes.preparation
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat();
            cat.Name = "Мурзик";
            cat.Age = 5;
            cat.Breed = "Манчкин";

            Dog dog = new Dog();
            dog.Name = "Шарик";
            dog.Age = 3;
            dog.Collar = true;

            Animal animal;

            animal = dog;
            animal.Say();

            animal = cat;
            animal.Say();

            Car car = new Car();
            animal = car;
        }

        static void run() { 
        }
    }
}
