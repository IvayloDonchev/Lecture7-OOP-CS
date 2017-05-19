using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture7
{
    class Program
    {
        public Task Handl(IndexOutOfRangeException e)
        {
            return new Task(null);
        }
        public  async Task Method()
        {
            int[] myArray = { 1, 2, 3, 4 };
            try
            {
                //..........................
                int myElem = myArray[4];
            }
            catch (IndexOutOfRangeException e) when (myArray.Length > 100)
            {
                await Handl(e);
            }
            finally
            {

            }
        }
        static void Main(string[] args)
        {
          
        }
    }
}
