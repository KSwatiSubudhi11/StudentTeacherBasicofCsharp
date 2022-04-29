using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    // T(n)=> O(n)
    class BubbleSort
    {
        static int[] array = { 43, 78, 21};
        public static void Do()
        {
            int n = array.Length;
            int counter = 0;
            // iteration loop
            for (int i = 0; i < n - 1; i++)
            {
                counter++;
                // swap loop
                for (int j = 0; j < n - i - 1; j++)
                {
                    counter++;
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine("Iterations " + counter);
        }
    }
}
