using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAITAPTRENLOP
{
    internal class Bai1CoDeQuy
    {
        static int TinhTong(int[] array, int index)
        {
            if (index == array.Length)
            {
                return 0;
            }
            else
            {
                return array[index] + TinhTong(array, index + 1);
            }
        }

        static int SumArray(int[] array)
        {
            return TinhTong(array, 0);
        }
        static void Main()
        {
            int[] array = { 1, 4, 7, 3, 5, 2, 6 };
            int sum = SumArray(array);
            Console.WriteLine("Tong cua mang la : {0}", sum);
        }
    }
}
