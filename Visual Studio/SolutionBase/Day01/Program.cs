using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//字面意思:正在使用xxxx命名空间
//引入命名空间



//定义命名空间[类的住址]：对类进行逻辑上的划分，避免重名
namespace Day01
{
    //定义类[做工具]
    internal class Program
    {
        //定义方法[做功能]
        //程序的入口方法
        static void Main1(string[] args)
        {

            //代码格式对齐：Ctrl+A  然后Ctrl+K+F
            //注释选中的代码：Ctrl+K+C
            //取消注释 Ctrl+K+U

            //字面意思：控制台.写一行（“内容”）;
            //现象:在控制台中显示括号内的文本
            //作用: 将括号中的文本写到控制台z

            Console.WriteLine("你好，世界!");

            // 字面意思:控制台.读一行();
            //现象：暂停程序(按回车键继续)
            //作用：将用户在控制台中输入的文本(OK) 读取到程序中来（input）
            String input = Console.ReadLine();
            Console.WriteLine(input);
            Console.ReadLine();

            //Console 是类[工具]
            //WriteLine/ReadLine是方法[动词的功能]
            //Title 是属性[名词的修辞]
            //类.方法(); 调用语句[使用某个类中的功能]


            String gunName = "AK47";
            float num1 = 0.1f;
            double num2 = 2.1;





        }
        static void Main()
        {

            //float num01 = 3.0f;
            //float num02 = 2.9f;
            //float result = num01 - num02;
            //bool b1 = result == 0.1f;
            //Console.WriteLine(b1);

            decimal num01 = 3.0m;
            decimal num02 = 2.9m;
            decimal result = num01 - num02;
            bool b1 = result == 0.1m;
            Console.WriteLine(b1);
            Console.ReadLine();

        }
    }
}
