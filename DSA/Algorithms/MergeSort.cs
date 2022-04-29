using System;
using System.Collections.Generic;
using System.Text;

namespace DSA.Algorithms
{
    class MergeSort
    {

        public void Do()
        {
            int[] array = { 23, 11, 34, 24, 67, 56 };
            Divide(array, 0, array.Length - 1);
            foreach (int num in array)
            {
                Console.Write(num + " ");
            }
        }

        void Divide(int[] array, int left, int right) // logn
        {
            if (left < right)
            {
                // 1. Find Mid.
                int mid = (left + right) / 2;

                // 2. Divide left array (Create pointers for left array)
                Divide(array, left, mid);

                // 3. Divide right array (Create pointers for right array)
                Divide(array, mid + 1, right);

                // 4. Merge and Sort.
                MergeAndSort(array, left, right, mid);
            }

        }

        void MergeAndSort(int[] array, int left, int right, int mid) // n
        {
            // 1. Create Left and Right array based on pointers.

            // 1.1 Length of arrays.
            int leftArrayLength = mid - left + 1;
            int rightArrayLength = right - mid;

            // 1.2 Create arrays left and right
            int[] leftArray = new int[leftArrayLength];
            int[] rightArray = new int[rightArrayLength];

            int i, j;
            for (i = 0; i < leftArrayLength; i++) // n
            {
                leftArray[i] = array[left + i];
            }

            for (j = 0; j < rightArrayLength; j++) // n
            {
                rightArray[j] = array[mid + 1 + j];
            }

            // 2. Merge and Sort.
            i = 0; j = 0;
            int k = left;

            while (i < leftArrayLength && j < rightArrayLength) // n
            {
                if (leftArray[i] < rightArray[j])
                {
                    array[k] = leftArray[i];
                    i++;
                }
                else
                {
                    array[k] = rightArray[j];
                    j++;
                }
                k++;
            }

            while (i < leftArrayLength)
            {
                array[k] = leftArray[i];
                i++;
                k++;
            }
            while (j < rightArrayLength)
            {
                array[k] = rightArray[j];
                j++;
                k++;
            }
        }
    }
}
