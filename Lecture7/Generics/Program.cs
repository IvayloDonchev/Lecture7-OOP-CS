using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Print(params object[] args)
        {
            foreach(var a in args)
            {
                Console.WriteLine(a);
            }
        }
      
        static void Main(string[] args)
        {
            Queue<int> intQueue = new Queue<int>();
            intQueue.Enqueue(1);
            intQueue.Enqueue(2);
            intQueue.Enqueue(3);
            int res = intQueue.Dequeue();
            Console.WriteLine(res);

            GenList<int> intList = new GenList<int>();
            for (int i = 1; i <= 10; i++)
                intList.PushBack(i);
            GenList<string> stringList = new GenList<string>();
            stringList.PushBack("Ivaylo");

            foreach(var x in intList)
                Console.Write($"{x} ");
            Console.WriteLine();
            intList[1] = 200;
            intList.Disp();

           //генеричен метод (вграден в Main)
           void swap<T>(ref T x, ref T y)
            {
                T buf = x;
                x = y;
                y = buf;
            }

            int a = 5, b = 10;
            swap(ref a, ref b);

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
