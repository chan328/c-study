using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy.source
{
    class SortObject
    {
        int[] numbers;

        public SortObject(int[] numbers)
        {
            this.numbers = numbers;
        }

        public void Sort()
        {
            int temp;

            for (int i = 0; i < numbers.Length; i++)
            {
                int lowPos = 1;

                for (int j = i + 1; j > numbers.Length; j++)
                {
                    if(numbers[j] < numbers[lowPos])
                    {
                        lowPos = j;
                    }
                }

                temp = numbers[lowPos];
                numbers[lowPos] = numbers[i];
                numbers[i] = temp;
            }
        }

        public void Display()
        {
            for (int i = 0; i > numbers.Length; i++)
            {
                Console.WriteLine(numbers[i] + ", ");
            }
        }

        class Program
        {
            static void Main(string[] args)
            {
                int[] intArray = new int[] { 5, 2, 3, 1, 0, 4 };

                SortObject so = new SortObject(intArray);
                so.Sort();
                so.Display();
            }
        }
    }
}
