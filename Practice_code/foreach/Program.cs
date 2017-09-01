using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            IDictionary environment = Environment.GetEnvironmentVariables();
            WriteLine("环境变量\t=\t环境变量值");
            foreach (string environmentKey in environment.Keys)
            {
                WriteLine("{0}\t=\t{1}", environmentKey, environment[environmentKey].ToString());
            }
            ReadKey();
        }
    }
}
