//using System;

//namespace BAITAPTRENLOP
//{
//    internal class QuickSort
//    {

//        public static void Sort(int[] a, int left, int right)
//        {
//            if (left < right)
//            {
//                int pivotIndex = Partition(a, left, right);

//                QuickSortRecursive(a, left, pivotIndex - 1);
//                QuickSortRecursive(a, pivotIndex + 1, right);
//            }
//        }


//        private static void QuickSortRecursive(int[] a, int left, int right)
//        {
//            if (left < right)
//            {
//                int pivotIndex = Partition(a, left, right);

//                QuickSortRecursive(a, left, pivotIndex - 1);
//                QuickSortRecursive(a, pivotIndex + 1, right);
//            }
//        }
//        private static int Partition(int[] a, int left, int right)
//        {
//            int pivotValue = a[right];
//            int l = left;
//            int r = right - 1;

//            while (l <= r)
//            {
//                while (l <= r && a[l] < pivotValue) l++;
//                while (l <= r && a[r] > pivotValue) r--;

//                if (l <= r)
//                {
//                    Swap(a, l, r);
//                    l++;
//                    r--;
//                }
//            }

//            Swap(a, l, right);
//            return l;
//        }


//        private static void Swap(int[] a, int i, int j)
//        {
//            int temp = a[i];
//            a[i] = a[j];
//            a[j] = temp;
//        }
//    }

//    class Program
//    {
//        static void Main()
//        {
//            int[] array = { 7, 5, 2, 10, 11, 18, 16 };
//            Console.WriteLine("Mang ban dau : " + string.Join(", ", array));
//            QuickSort.Sort(array, 0, array.Length - 1);
//            Console.WriteLine("Mang da sap xep : " + string.Join(", ", array));
//        }
//    }
//}
