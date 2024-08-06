using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInAccessSettings
{
    public class Vehicle
    {
        protected string model;
        private int engineCapacity;

        public Vehicle(int capacity)
        {
            engineCapacity = capacity;
        }
    }
}