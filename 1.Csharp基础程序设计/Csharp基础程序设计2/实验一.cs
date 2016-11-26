using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Csharp基础程序设计2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello，My name is LiNing, This is my first csharp program");
            Console.WriteLine("我的C#学习之旅开始了");
            //等待任意输入后结束程序运行
            Console.ReadLine();
            */
            /*
            int myInt = 3;
            short myShort = 32765;
            uint myUint = 1;
            float myFloat = 100.15f;
            double myDouble = -99;
            long myLong = 10000;
            decimal myDecimal = -1.88m;
            Console.WriteLine("myInt:{0},myShort:{1},myUint:{2},myFloat:{3}", myInt, myShort, myUint, myFloat);
            Console.WriteLine("myDouble:{0},myLong:{1},myDecimal:{2}", myDouble, myLong, myDecimal);
            Console.ReadLine();   
            */
            /*
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j+"*"+i+"="+j * i+"\t");                   
                }
                Console.WriteLine();
            }
            */
            //2-100000的素数,两重循环
            for (int i = 5; i < 100; i++) 
            {
                int iSqrt = (int)Math.Sqrt(i);
                for (int j = 1; j <= iSqrt; j += 2) 
                {                   
                }
            }
        }
    }//3个窗口类 3个button （第一个窗口按钮 一按，显示第二个窗口，关闭第一个窗口）
}
