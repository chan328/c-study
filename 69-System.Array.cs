using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class Class2
    {
        public static void OutputArrayInfo(Array arr)
        {
            System.Console.WriteLine("배열의 차원 수" + arr.Rank);
            System.Console.WriteLine("매열의 요소 수" + arr.Length);
            System.Console.WriteLine();
        }
        private static void OutputArrayElements (string title, Array arr)
        {
            System.Console.WriteLine("[" + title + "]");

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr.GetValue(i) + ", ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            bool[,] boolArray = new bool[,] { { true, false }, { false, false } };
            OutputArrayInfo(boolArray);

            int[] intArray = new int[] { 5, 4, 3, 2, 1, 0 };
            OutputArrayInfo(intArray);

            OutputArrayElements("원본 intArray", intArray);
            Array.Sort(intArray);
            OutputArrayElements("Array.sort 후 int Array", intArray);

            int[] copyArray = new int[intArray.Length];
            Array.Copy(intArray, copyArray, intArray.Length);

            OutputArrayElements("intArray로 부터 복사된 copyArray", copyArray);
        }
    }
}
