using System;

namespace _001_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            // 变量类型 变量名;
            int number; // int 用来表示整数类型
            // 给变量赋值
            number = 3;
            Console.WriteLine(number);

            double d = 3.14; // 浮点数类型
            Console.WriteLine(d);

            string str = "张三"; // 字符串类型
            Console.WriteLine(str);

            char ccc = 'Y'; // 字符类型
            Console.WriteLine(ccc);

            decimal monry = 5000m; // decimal类型，常量结尾要加 m，精确到小数点28-29位
            Console.WriteLine(monry);

            string name = Console.ReadLine();
            Console.WriteLine("用户的姓名是：" + name);

            // 尝试进行转换
            // 若成功：将转换结果赋值给number，返回true
            // 若失败：将number赋值为0，返回false
            bool canConvert = int.TryParse("123asd", out number);
            Console.WriteLine(canConvert);
            Console.WriteLine(number);

            Console.ReadKey(true);

            int aaaa = 1;
            Fun(out aaaa);
            Console.WriteLine(aaaa);
        }

         static void Fun(out int result)
        {
            result = 3;
        }
    }
}
