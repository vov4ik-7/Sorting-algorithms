using System;
using System.Linq;

namespace sortingAlgorithms
{
    static class Algorithm
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
