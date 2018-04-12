using System;
using System.Linq;

namespace sortingAlgorithms
{
    static class Algorithm
    {
        public static void selectionSort(int[] arr, int n)
        {
            for (int i = 0; i < n; ++i) {
                int temp = arr[0];
                for (int j = i + 1; j < n; ++j) {
                    if (arr[i] > arr[j]) {
                        temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public static void insertionSort(int[] array)
        {
            int length = array.Length;

            for (int i = 1; i < length; i++) {
                int j = i;

                while ((j > 0) && (array[j] < array[j - 1])) {
                    int k = j - 1;
                    int temp = array[k];
                    array[k] = array[j];
                    array[j] = temp;

                    j--;
                }
            }
        }
    }
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(">Testing insertion sort");
            Console.WriteLine("Unordered array:");
            int[] arr = new int[] { -12, 5, 2, 12, 6, 1, 1, 0, 0, 7, 18 };
            Algorithm.insertionSort(arr);
            foreach (var elem in arr) {
                Console.Write($"{elem} ");
            }
            Console.WriteLine("\nOrdered array:");
            int[] arr1 = new int[] { -5, -2, 0, 4, 7, 20, 43, 98 };
            Algorithm.insertionSort(arr1);
            foreach (var elem in arr1) {
                Console.Write($"{elem} ");
            }
            Console.WriteLine('\n');

            Console.WriteLine(">Testing selection sort");
            Console.WriteLine("Unordered array:");
            int[] arr2 = new int[] { -100, 50, 65, 1, 0, 1, 1, 1, 90, 54, 34, -4, 0, 23, -11 };
            Algorithm.selectionSort(arr2, arr2.Length);
            foreach (var elem in arr2) {
                Console.Write($"{elem} ");
            }
            Console.WriteLine("\nOrdered array:");
            int[] arr3 = new int[] { -98, -4, 0, 1, 1, 1, 9, 34, 67, 87, 87 };
            Algorithm.selectionSort(arr3, arr3.Length);
            foreach (var elem in arr3)
            {
                Console.Write($"{elem} ");
            }
        }
    }
}
