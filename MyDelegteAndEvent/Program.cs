using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDelegteAndEvent
{
    /// <summary>
    /// 打招呼委托
    /// </summary>
    /// <param name="name"></param>
    public delegate void GreatingDelegate(string name);
    class Program
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("hello"+name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("你好" + name);
        }

        private static void GreetPeople(string name,GreatingDelegate MakeGreeting)
        {
            //将方法作为方法的参数传递
            MakeGreeting(name);
        }
        static void Main(string[] args)
        {
            //1 方式1：将方法作为参数传递
            //GreetPeople("casablanca", EnglishGreeting);
            //GreetPeople("小王", ChineseGreeting);

            //2 方式2：
            //GreatingDelegate delegates;
            //delegates = EnglishGreeting;
            //delegates += ChineseGreeting;
            ////2.1 调用方式1
            //GreetPeople("drno", delegates);
            ////2.2 调用方式2
            //delegates("drno");

            //3 方式3：
            GreatingDelegate delegates1 = new GreatingDelegate(EnglishGreeting);
            delegates1 += ChineseGreeting;
            delegates1("drno");

            Console.ReadLine();
        }
    }
}
