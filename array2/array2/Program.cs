using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] randArray = {1, 2, 3, 4};
            printArray(randArray, "ForEach");

        }
        static void printArray(int[] intArray,string mess)
        {
            foreach(int k in intArray)
            {
                Console.WriteLine("{0} {1}",mess,k);
            }
        }
    }
}
