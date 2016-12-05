using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    public class People
    {
        public string Name;
        public int? Age;
        public string FavCol;
        public List<Pet> Pets;
        public Car TheCar;



        public People(string name, int age, Car theCar)
        {
            Name = name;
            Age = age;
            Pets = new List<Pet>();
            TheCar = theCar;
        }

        public People(string name, string favColor)
        {
            Name = name;
            FavCol = favColor;
            Pets = new List<Pet>();
        }
        public People(int age, string name)
        {
            Name = name;
            Age = age;
            Pets = new List<Pet>();
        }

        public People(string name, int age, bool customSort)
        {
            Age = age;
            Pets = new List<Pet>();
            Name = name;
        }


    }
}
