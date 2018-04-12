using System;
using System.Linq;

namespace sortingAlgorithms
{
    public class Tree
    {
        public Tree left;
        public Tree right;
        public int key;

        public Tree(int _key)
        {
            key = _key;
        }

        public void Insert(Tree tr)
        {
            if (tr.key < key)
            {
                if (left != null)
                {
                    left.Insert(tr);
                }
                else
                {
                    left = tr;
                }
            }
            else
            {
                if (right != null)
                {
                    right.Insert(tr);
                }
                else
                {
                    right = tr;
                }
            }
        }

        public void Traverse(TreeVisitor visitor)
        {
            if (left != null)
            {
                left.Traverse(visitor);
            }
            visitor.visit(this);
            if (right != null)
            {
                right.Traverse(visitor);
            }
        }
    }
    public interface TreeVisitor
    {
        void visit(Tree node);
    }

    class KeyPrinter : TreeVisitor
    {
        public void visit(Tree node)
        {
            Console.Write(node.key + " ");
        }
    }
    
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
        public static void quickSort (int[] arr, int left, int right) 
        {
            int i = left, j = right;
            int curr;
            int pivot = arr[(left + right) / 2];

            while (i <= j) {
                while (arr[i] < pivot) {
                    i++;
                }
                while (arr[j] > pivot) {
                    j--;
                }
                if (i <= j) {
                    curr = arr[i];
                    arr[i] = arr[j];
                    arr[j] = curr;
                    i++;
                    j--;
                }
            }

            if (left < j) {
                quickSort(arr, left, j);
            }
            if (i < right) {
                quickSort(arr, i, right);
            }
        }
        public static void countingSort(int[] array) 
        {
            int min = array.Min();
            int fmin;
            if (min < 0) {
                fmin = min / -1;
            }
            else if (min > 0) {
                fmin = -min;
            }
            else {
                fmin = 0;
            }
            int max = array.Max();

            int[] arrIndex = new int[max - min + 1];

            for (int i = 0; i < array.Length; ++i) {
                arrIndex[array[i] + fmin]++;
            }

            int j = 0;
            for (int i = 0; i < arrIndex.Length; ++i) {
                while (arrIndex[i] > 0)
                {
                    array[j] = i - fmin;
                    j++;
                    arrIndex[i]--;
                }
            }
        }
        public static void bubbleSort(int[] a, int n)
        {
            for (int j = n - 1; j > 0; --j)
            {
                for (int i = 0; i < j; ++i)
                {
                    if (a[i] > a[i + 1])
                    {
                        int toSwap = a[i];
                        a[i] = a[i + 1];
                        a[i + 1] = toSwap;
                    }
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
