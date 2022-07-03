using System;
using System.Collections.Generic;
using System.Text;

namespace NeedForSpeed
{
    public class Car : Vehicle
    {
        public Car(int horsePower, double fuel) : base(horsePower, fuel)
        {

        }

        public override double FuelConsumption => 3;

        //public int DriveMe()
        //{
        //    return base.Speed * 5;
        //}

        //public override void Drive(double kilometers)
        //{
        //    Console.WriteLine("You spin me round round!");
        //}
    }
}
