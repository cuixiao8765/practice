using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Array_try_catch
{
    class Array_try_catch
    {
        public static void Main()
        {
            int typeInNum = 0;//定义存储数组总长度的变量
            while (1 == 1)
            {
                try
                {
                    typeInNum = getInNum();//调用函数判断输入的数据是否符合要求
                    break;
                }
                catch (Exception ex)
                {
                    WriteLine(ex.Message);
                }
            }
            int[] array = new int[typeInNum];//设置数组总长度
            for (int i = 0; i < typeInNum; i++)//输入数组元素
            {
                WriteLine("请输入第{0}元素：", i + 1);
                array[i] = int.Parse(ReadLine());
            }
            WriteLine("该数组为：");
            foreach (int item in array)//显示数组内元素
            {
                Write("{0} ", item);
            }
            ReadKey();
        }
        private static int getInNum()
        {
            WriteLine("请输入数组总长度：");
            string totalNum = ReadLine();//获取输入数据
            try
            {
                int getNum = int.Parse(totalNum);//验证是否为整型
                if (getNum < 0 || getNum > 100) throw new Exception("输入数据不在有效范围内，有效范围为0-100");//判断数字范围
                return getNum;
            }
            catch (FormatException ex)
            {
                throw new FormatException("输入格式不正确，请输入0-100内整数！" + ex.Message);
            }
            catch (OverflowException ex)
            {
                throw new OverflowException("输入数值过大！" + ex.Message);
            }
            catch (Exception ex)
            {
                throw new Exception("错误：" + ex.Message);
            }
        }
    }
}
