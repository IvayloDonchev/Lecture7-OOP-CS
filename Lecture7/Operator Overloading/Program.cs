using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operator_Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Ivaylo", 1971);
            Person p2 = new Person("Victoria", 2002);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            if (p1>p2)
                Console.WriteLine($"{p1.Name} is older");

            Vector A, B;
            A = new Vector(3, 4);
            B = new Vector(-3, -4);
            Console.WriteLine(A>B);
            Console.WriteLine(A<B);
            Console.WriteLine(A==B);
        }
    }
}
