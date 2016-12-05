using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class Person
    {
        public int? Age;
        public List<Pet> Pets;
        public string Name;



        public Person(string name, int age)
        {
            Age = age;
            Pets = new List<Pet>();
            Name = name;

        }

        public Person(string name)
        {
            Pets = new List<Pet>();
            Name = name;

        }
    }
}
