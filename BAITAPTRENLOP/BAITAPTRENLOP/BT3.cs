//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace BAITAPTRENLOP
//{
//    internal class BT3
//    {
//        public static int BinarySearch(int[] a, int x)
//        {
//            int left = 0;
//            int right = a.Length - 1;

//            while (left <= right)
//            {
//                int mid = (left + right) / 2;

//                if (a[mid] == x)
//                {
//                    return mid;
//                }
//                else if (a[mid] > x)
//                {
//                    right = mid - 1;
//                }
//                else
//                {
//                    left = mid + 1;
//                }
//            }

//            return -1;
//        }
//        static void Main()
//        {
//            int[] array = { 2, 5, 8, 12, 16, 23, 38, 56, 72, 91 };
//            int x = 23;

//            int result = BinarySearch(array, x);

//            if (result != -1)
//            {
//                Console.WriteLine($"Phan tu duoc tim thay tai chi so  la {result}.");
//            }
//            else
//            {
//                Console.WriteLine($"Phan tu khong duoc tim thay trong mang .");
//            }
//        }
//    }
//}


