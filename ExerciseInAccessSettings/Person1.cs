using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseInAccessSettings
{
    public class Person1
    {
        private int age { get; set; } 

        public void SetAge(int Age)
        {
            this.age = Age;
        }
        public int GetAge() { return this.age; }
    }
}
