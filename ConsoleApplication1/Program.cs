using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySortsLibrary;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100000000];
            Random r = new Random();
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(-10000, 10000);
            }
            Sorts b = new Sorts();
            //for (int i = 0; i < a.Length; i++)
            //{
            //    Console.Write(a[i] + " ");
            //}
            //Console.ReadKey();
            var before = DateTime.UtcNow;
            //b.bubbleSort(a);
            //b.insertionSort(a);
            //b.selectionSort(a);
            b.quickSort(a,0,a.Length-1);
            //int[] c = b.mergeSort(a);
            var potracheno = DateTime.UtcNow - before;
            Console.WriteLine("Время сортировки: " + potracheno.ToString());
            Console.WriteLine();
            /*for (int i = 0; i < c.Length; i++)
            {
                Console.Write(c[i] + " ");
            }
            Console.WriteLine();*/
            /*for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }*/
            Console.WriteLine();
            Console.ReadKey();
            
        }
    }
}
