using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace @while
{
    class Program
    {
        static void Main(string[] args)
        {
            //屏幕输入提示
            WriteLine("type you commond");
            WriteLine(">");

            string c;//定义存储命令变量
            while ((c = ReadLine()) != "exit")//如不等于exit则进行循环
            {
                switch (c)
                {
                    case "put":
                        doput();
                        break;
                    case "get":
                        doget();
                        break;
                    default:
                        dodefault();
                        break;
                }
                WriteLine(">");

            }
        }
        public static int doput()
        {
            WriteLine("放入数据中.....");
            return 0;
        }
        public static int doget()
        {
            WriteLine("取得数据中......");
            return 0;
        }
        public static int dodefault()
        {
            WriteLine("命令错误...");
            WriteLine("正确命令为：");
            WriteLine("放入数据：put");
            WriteLine("取得数据：get");
            WriteLine("退出：exit");

            return 0;
        }
    }
}
