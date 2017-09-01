using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace dowhile
{
    class dowhile
    {
        static void Main(string[] args)
        {
            WriteLine("type you commond");
            string c;
            do
            {
                WriteLine(">");
                switch (c = ReadLine())
                {
                    case "get":
                        doget();
                        break;
                    case "put":
                        doput();
                        break;
                    default:
                        dodefault();
                        break;
                }
            } while ((c = ReadLine()) != "exit");

        }
        public static int doget()
        {
            WriteLine("读取数据...");
            return 0;
        }
        public static int doput()
        {
            WriteLine("存储数据...");
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
