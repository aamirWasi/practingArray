using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace array2
{
    class Program
    {
        static void Main(string[] args)
        {

            //int[] randArray = {11, 23, 3, 4};
            // Console.WriteLine(Array.IndexOf(randArray,-1));
            //randArray.SetValue(0, 1);
            //printArray(randArray, "ForEach");
            int[] srcArray = { 1, 2, 3,4,5,6 };
            int[] destArray = new int[6];
            int startInd = 0;
            int length = 6;
            Array.Copy(srcArray, startInd, destArray, startInd, length);

            Array anotherArray = Array.CreateInstance(typeof(int), 10);
            srcArray.CopyTo(anotherArray, 2);
            //foreach(int m in anotherArray)
            //{
            //    Console.WriteLine("{0}",m);
            //}
            //printArray(destArray, "Copy");
            //matching value
            int[] numArray = { 1, 2, 3, 4, 6, 56,10 };
            //Console.WriteLine("> 10 :{0}",Array.FindIndex(numArray,GT8));
            long num1 = 1234;
            int num2 = (int)num1;
            Console.WriteLine("Orig :{0} Cast :{1}",num1.GetType(),num2.GetType());


            //String Builder
            StringBuilder sb = new StringBuilder("Random Text");
            StringBuilder sb2 = new StringBuilder("More stuff that is important text",400);

            //Console.WriteLine("Capacity :{0}",sb.Capacity);
            //Console.WriteLine("Capacity :{0}",sb2.Capacity);
            Console.WriteLine("Length :{0}",sb.Length);
            Console.WriteLine("Length :{0}",sb2.Length);

            //Add Text in stringBuilder
            sb2.AppendLine(".More important task text& that's great Work");
            //Console.WriteLine(sb2);
            CultureInfo enUs = CultureInfo.CreateSpecificCulture("en-Us");
            string bestCust = "aamir wasi";
            sb2.AppendFormat(enUs,"\nBest Customer :{0}",bestCust);
            Console.WriteLine(sb2.ToString());

            sb2.Replace("text", "characters");
            Console.WriteLine(sb2.ToString());
            sb2.Clear();
            Console.WriteLine(sb2);
            sb2.Append("Random Text");
            Console.WriteLine(sb2);
            Console.WriteLine(sb.Equals(sb2));
            //Console.WriteLine(sb2);

            sb2.Insert(11," that's great");
            Console.WriteLine(sb2.ToString());
            sb2.Remove(11,7);
            Console.WriteLine(sb2.ToString());

        }
        private static bool GT8(int val)
        {
            return val > 8;
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
