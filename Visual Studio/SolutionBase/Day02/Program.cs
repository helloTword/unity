using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String gunName = "AK47";
            String ammoCapacity = "30";
            //在字符串中插入变量
            Console.WriteLine("枪的名字为：" + gunName + ";枪的容量为：" + ammoCapacity);
            //占位符{位置的编号}   如果编号大于参数列表长度，则异常
            String gun = String.Format("枪的名字为：{0};枪的容量为：{1}", gunName, ammoCapacity);
            Console.WriteLine(gun);


            // 0:c   {0:c}->¥xx.00  标准数字字符串格式化
            Console.WriteLine("金额:{0:c}", 10);//货币
            Console.WriteLine("{0:d2}", 5);  //  :d2 不满足两位，前面添0
            Console.WriteLine("{0:d2}", 15);
            Console.WriteLine("{0:f1}", 1.5678);//1.5678  根据指定精度显示
            Console.WriteLine("{0:p0}", 0.1);//10%  转化为百分数

            //转义 改变字符原始含义 \"  \'
            Console.WriteLine("我爱\"unity\"!");
            char c = '\'';
            Console.WriteLine(c);

            //空字符
            String a="a131\0131231\0";
            Console.WriteLine(a);
            // \n回车换行
            Console.WriteLine("您好,我是隔壁人!");
        }
    }
}
