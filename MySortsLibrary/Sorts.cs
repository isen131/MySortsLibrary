using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySortsLibrary
{
    public class Sorts
    {
        public int ns = 0;

        public void bubbleSort(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[i])
                    {
                        int temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
        }

        public void insertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int cur = array[i];
                int j = i;
                while (j > 0 && cur < array[j - 1])
                {
                    array[j] = array[j - 1];
                    j--;
                }
                array[j] = cur;
            }
        }


        public void selectionSort(int[] array)
        {  
             for (int i = 0; i < array.Length; i++)
             {
                 int min = i;
                 int tmp = array[i];
                 for (int j = i + 1; j < array.Length; j++)
                 {
                     if (array[j] < tmp)
                     {
                         min = j;
                         tmp = array[j];
                     }
                 }
                 array[min] = array[i];
                 array[i] = tmp;
             }
        }

        public int[] mergeSort(int[] massive)
        {
            if (massive.Length == 1)
                return massive;
            int mid_point = massive.Length / 2;
            return merge(mergeSort(massive.Take(mid_point).ToArray()), mergeSort(massive.Skip(mid_point).ToArray()));
        }
        public int[] merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0, ns = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b])
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
            }
            Console.WriteLine();
            return merged;
        }

        public void quickSort(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i;
                    --j;
                }
            }
            if (j > first) quickSort(arr, first, j);
            if (i < last) quickSort(arr, i, last);
        }
    }
}