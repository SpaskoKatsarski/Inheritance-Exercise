using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public virtual void ProduceSound()
        {

        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(GetType().Name);
            sb.AppendLine($"{Name} {Age} {Gender}");
            return sb.ToString().TrimEnd();
        }
    }
}
