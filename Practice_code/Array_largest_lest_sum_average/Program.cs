using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace test_code
{
    /// <summary>
    /// 输入一个数组，并取得其中的最大值、最小值、平均值、总和
    /// </summary>
    class Array_largest_lest_sum_average
    {
        public static void Main()
        {
            WriteLine("输入数组的最大长度：");
            int Numlength = int.Parse(ReadLine());
            int[] array = new int[Numlength];
            for (int i = 0; i < Numlength; i++)
            {
                WriteLine("输入第{0}个数组元素：", i + 1);
                array[i] = int.Parse(ReadLine());
            }
            WriteLine("该数组的最大值为：{0}", largestNum(array));
            WriteLine("该数组的最小值为：{0}", lestNum(array));
            WriteLine("该数组的总和为：{0}", sumNum(array));
            WriteLine("该数组的平均值为：{0}", averageNum(array));



            ReadKey();
        }

        #region 数组中的最大值
        private static int largestNum(int[] array)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > j)
                {
                    j = array[i];
                }
            }
            return j;
        }
        #endregion

        #region 数组中的最小值
        private static int lestNum(int[] array)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                j = array[0];
                if (array[i] < j)
                {
                    j = array[i];
                }
            }
            return j;
        }
        #endregion

        #region 数组总和
        private static int sumNum(int[] array)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                j += array[i];
            }
            return j;
        }
        #endregion

        #region 数组平均值
        private static double averageNum(int[] array)
        {
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                j += array[i];
            }
            double k = j * 1.0 / array.Length;
            return k;
        }
        #endregion

    }
}
