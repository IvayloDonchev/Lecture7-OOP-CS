using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    public class Person
    {
        private string name;
        private readonly int year;
        public string Name { get => name; set => name = value; }
        public int Age => DateTime.Today.Year - year;
        public Person(string name, int year)
        {
            this.name = name;
            this.year = year;
        }
        public override string ToString() => $"{name}, born {year} (Age {Age})";
        public static bool operator <(Person a, Person b)
        {
            return a.year > b.year;
        }
        public static bool operator >(Person a, Person b)
        {
            return a.year < b.year;
        }
    }
}
