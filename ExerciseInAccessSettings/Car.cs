using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInAccessSettings
{
    public class Car : Vehicle
    {
        internal int numberOfDoors;

        public Car(int capacity, int doors) : base(capacity)
        {
            numberOfDoors = doors;
        }

        public string GetCarInfo()
        {
            return $"Model: {model}, Doors: {numberOfDoors}";
        }
    }
}
