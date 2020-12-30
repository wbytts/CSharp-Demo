using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_数据类型
{
    class V
    {
        public int value = 0;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int one = 300;
            // {x} 占位符，对应后续的参数，从0开始
            Console.WriteLine("num is {0}", one);

            double cv = Convert.ToDouble(one);

            V v = new V();

        }
    }
}
