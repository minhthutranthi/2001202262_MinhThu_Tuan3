//using System;

//namespace BAITAPTRENLOP
//{
//    internal class BT3CoDeQuy
//    {
        
//        public static int BinarySearch(int[] a, int left, int right, int x)
//        {
//            if (left > right)
//            {
//                return -1; 
//            }

//            int mid = (left + right) / 2;

//            if (a[mid] == x)
//            {
//                return mid; 
//            }
//            else if (a[mid] > x)
//            {
//                return BinarySearch(a, left, mid - 1, x); 
//            }
//            else
//            {
//                return BinarySearch(a, mid + 1, right, x); 
//            }
//        }

//        static void Main()
//        {
//            int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
//            int x = 23;

//            int result = BinarySearch(array, 0, array.Length - 1, x);

//            if (result != -1)
//            {
//                Console.WriteLine($"Phan tu duoc tim thay tai chi so  {result}.");
//            }
//            else
//            {
//                Console.WriteLine("Phan tu khong duoc tim thay trong mang .");
//            }
//        }
//    }
//}
