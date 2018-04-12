using System;
using System.Linq;

//really cool algorithms

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
            int[] arr = new int[] { -12, 5, 2, 12, 6, 1, 1, 0, 0, 7, 18 };
        }
    }
}
