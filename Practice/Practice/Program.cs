using System;
using System.Linq;
using System.Reflection;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            string testType = Console.ReadLine();
            string testPath = Console.ReadLine();

            var assembly = Assembly.GetExecutingAssembly();
            var type = assembly.GetTypes().FirstOrDefault(x => x.Name == testType);

            bool typeExists = type != null;

            if (testPath == "exists")
            {

                // Test if type exists at all
                Console.WriteLine(typeExists ? "exists" : "!exist");

            }
            else if (typeExists && testPath == "correct")
            {

                // Test implementation of the classes
                Animal animal = (Animal)Activator.CreateInstance(type);

                // Setting some animal properties
                animal.Name = "Tommy";
                animal.Age = 3;
                animal.Gender = animal.Gender == Gender.Male ? Gender.Female : Gender.Male;

                // Actual test
                //TestAnimal(animal);
            }
            else if (typeExists && testPath == "abstraction")
            {

                // Test abstraction level
                Console.WriteLine(type.IsAbstract);
                Console.WriteLine(type.GetMethod("ProduceSound").IsAbstract);
            }
        }
        static void TestAnimal(Animal animal)
        {

            // Test produce sound
            Console.WriteLine(!string.IsNullOrEmpty(animal.ProduceSound()));

            // Test genders
            if (animal.GetType().Name == "Kitten")
            {
                Console.WriteLine(animal.Gender == Gender.Female);
            }
            else if (animal.GetType().Name == "Tomcat")
            {
                Console.WriteLine(animal.Gender == Gender.Male);
            }
        }

    }

    enum Gender
    {
        Unknown, // Default one
        Male,
        Female,
    }

    abstract class Animal
    {
        public DateTime? Type { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        internal Gender Gender { get; set; }
        public abstract string ProduceSound();

    }

    class Dog : Animal
    {
        public override string ProduceSound()
        {
            return "Bark";
        }
    }

    class Frog : Animal
    {
        public override string ProduceSound()
        {
            return "Kwak=Kwak";
        }
    }

    abstract class Cat : Animal
    {
        public override string ProduceSound()
        {
            return "Meow";
        }
    }

    class Kitten : Cat
    {

    }
    class Tomcat : Cat
    {


    }

}
