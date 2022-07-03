using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            string type;
            while ((type = Console.ReadLine()) != "Beast!")
            {
                if (type != "Cat" && type != "Dog" && type != "Frog" && type != "Tomcat" && type != "Kitten")
                {
                    throw new Exception("Invalid input!");
                }

                string[] animalInfo = Console.ReadLine()
                    .Split();
                //Cat
                //Tom 12 Male
                Animal currAnimal;
                string name = animalInfo[0];

                if (!IsAgeValid(animalInfo))
                {
                    throw new Exception("Invalid input!");
                }

                int age = int.Parse(animalInfo[1]);
                
                if (type == "Cat")
                {
                    if (!IsGenderValid(animalInfo[2]))
                    {
                        throw new Exception("Invalid input!");
                    }

                    currAnimal = new Cat(name, age, animalInfo[2]);
                }
                else if (type == "Dog")
                {
                    if (!IsGenderValid(animalInfo[2]))
                    {
                        throw new Exception("Invalid input!");
                    }

                    currAnimal = new Dog(name, age, animalInfo[2]);
                }
                else if (type == "Frog")
                {
                    if (!IsGenderValid(animalInfo[2]))
                    {
                        throw new Exception("Invalid input!");
                    }

                    currAnimal = new Frog(name, age, animalInfo[2]);
                }
                else if (type == "Tomcat")
                {
                    currAnimal = new Tomcat(name, age);
                }
                else if (type == "Kitten")
                {
                    currAnimal = new Kitten(name, age);
                }
                else
                {
                    currAnimal = null;
                }

                animals.Add(currAnimal);
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal);
                animal.ProduceSound();
            }
        }

        public static bool IsAgeValid(string[] arr)
        {
            string value = arr[1];
            int number;

            if (!int.TryParse(value, out number) || int.Parse(value) < 0)
            {
                return false;
            }

            return true;
        }

        public static bool IsGenderValid(string gender)
        {
            if (gender == "Male" || gender == "Female")
            {
                return true;
            }

            return false;
        }
    }
}
