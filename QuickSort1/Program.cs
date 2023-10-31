using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort1
{

    class Program
    {
        static void Main(string[] args)
        {
            runApp();
        }

        static void runApp()
        {
            int[] marks = { 75, 89, 62, 98, 54, 81, 70, 92, 88, 67 };

            Console.WriteLine("Unsorted Marks:");
            DisplayMarks(marks);
            

            // Sort the subject marks in ascending order using Quick Sort
            quickSort(marks, 0, marks.Length - 1);

            Console.WriteLine("Sorted Marks (Ascending Order):");
            DisplayMarks(marks);
            Console.ReadLine();
        }
        

        static void quickSort(int[] arr, int low, int high)
        {
            int pivot;
            if (low < high)
            {
                 pivot = Partition(arr, low, high);

                quickSort(arr, low, pivot - 1);
                quickSort(arr,pivot + 1, high);
            }
        }

        static int Partition(int[] arr, int low, int high)
        {
            int pivot = arr[high];
            int i = (low - 1);

            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    Swap(ref arr[i], ref arr[j]);
                }
            }

            Swap(ref arr[i + 1], ref arr[high]);
            return (i + 1);
        }

        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        static void DisplayMarks(int[] marks)
        {
            foreach (int mark in marks)
            {
                Console.Write(mark + " ");
            }
            Console.WriteLine();
        }
    }
}

