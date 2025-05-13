using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EVEDRI_Github_Exercise
{
    public class Person
    {
        public string Name { get; set; }    
        public int Age { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine("Name: " + Name + "Age: " + Age);

        }
    }
}
