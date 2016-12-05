using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectComparer
{
    class Program
    {
        static void Main(string[] args)
        {
            Person personA = new Person("Adam", 30);
            Person personB = new Person("Berit", 30);

            //Car carA = new Car("AzureBlue", 4);
            //People peopleA = new People("Adam", 30, carA);
            //Pet petA = new Pet("Adams Hund", "Dog");
            //peopleA.Pets.Add(petA);

            //Car carB = new Car("Black", 4);
            //People peopleB = new People("Bertil", 30, carB);
            //Pet petB = new Pet("Adams Hund", "Dog");
            //peopleB.Pets.Add(petB);


            //People peopleC = new People("Bertil");

            // Adding a comment for GitHub.

            List<Variance> variances = personA.DetailedCompare(personB);
            
            foreach (var vari in variances)
            {
                Console.WriteLine(string.Format("{0}: \t {1} \t {2}",vari.prop,vari.valA, vari.valB));
            }

            var stophere = 3;
        }
    }
}
