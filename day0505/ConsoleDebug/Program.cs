using System;

namespace ConsoleDebug
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Caculator caculator = new Caculator();
            Console.WriteLine(caculator.add(5.6,2));
            Console.WriteLine("请输入一个数字");
            try
            {
                String str=Console.ReadLine();
                int x = Convert.ToInt32(str);
                Console.WriteLine(x);
            }
            catch
            {
                Console.WriteLine("对不起，您输入的数据不符合要求");
            }
        }
    }

    class Student
    {
        public int age
        {
            get { return this.age; }
            set
            {
                if (value > 0 && value <= 100)
                    this.age = value;
                else
                    Console.WriteLine("年龄输入不合法");
            }
        }
    }
}
