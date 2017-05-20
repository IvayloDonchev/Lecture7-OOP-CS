using System;
using System.Collections;
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


            // List<T>
            List<int> numbers = new List<int>();
            // Запълване на List<int> с метода Add()
            foreach (int number in new int[] { 10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 1 })
            {
                numbers.Add(number);
            }
            // Вмъкване на 99 на предпоследна позиция
            numbers.Insert(numbers.Count - 1, 99);
            // Изтрива първия елемент със стойност 7
            numbers.Remove(7);
            // Изтрива елемента на 7-ма позиция, индекс 6 (10)
            numbers.RemoveAt(6);
            // Обходжане на списъка с for и индексна нотация
            Console.WriteLine("Iterating using a for statement:");
            for (int i = 0; i < numbers.Count; i++)
            {
                Console.Write("{0} ",numbers[i]);
            }
            Console.WriteLine();
            // Сортиране на списъка
            numbers.Sort((int x, int y) => { // ламбда функция за сравняване на елементите
                if (x > y) return -1;        // за да се сортира в низходящ ред
                else if (x < y) return 1;
                else return 0;
            });
            // Обхождане на списъка с оператор foreach
            Console.WriteLine("\nIterating using a foreach statement:");
            foreach (int number in numbers)
            {
                Console.Write("{0} ",number);
            }
            Console.WriteLine();

            // Dictionary
            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("Doroteya", 40);  // добавяне с метода Add()
            ages.Add("Ivaylo", 45);
            ages["Victoria"] = 14; // добавяне с индексна нотация
            ages["Petar"] = 8;
            // обхождане с оператора foreach 
            Console.WriteLine("The Dictionary contains:");
            foreach (var element in ages) // типът на element e KeyValuePair<string, int>
            {
                Console.WriteLine("Name: {0}, Age: {1}", element.Key, element.Value);
            }

            //Custom-defined collection GenList
            GenList<int> nums = new GenList<int>();
            // Запълване на List<int> с метода Add()
            foreach (int number in new int[] { 10, 9, 8, 7, 7, 6, 5, 10, 4, 3, 2, 1 })
            {
                nums.PushBack(number);
            }
            // Обходжане на списъка с for и индексна нотация
            Console.WriteLine("Iterating using a for statement:");
            for (int i = 0; i < nums.Count; i++)
            {
                Console.Write("{0} ", nums[i]);
            }
            Console.WriteLine();
           
            // Обхождане на списъка с оператор foreach
            Console.WriteLine("\nIterating using a foreach statement:");
            foreach (int number in nums)
            {
                Console.Write("{0} ", number);
            }
            Console.WriteLine();

            //Indexers
            var stringCollection = new SampleCollection<string>();      //SampleCollection.cs
            stringCollection[0] = "Hello, World!";
            Console.WriteLine(stringCollection[0]);

            //Итератори
            IEnumerable SimpleList()
            {
                yield return "string 1";
                yield return "string 2";
                yield return "string 3";
                yield break;
            }
           
            foreach (string item in SimpleList())
                Console.WriteLine(item);
 
          

        }
    }
}
