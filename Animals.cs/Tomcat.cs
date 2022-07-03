﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Tomcat : Cat
    {
        private const string TomcatGender = "Male";

        public Tomcat(string name, int age) : base(name, age, TomcatGender)
        {

        }

        public override void ProduceSound()
        {
            Console.WriteLine("MEOW");
        }
    }
}
