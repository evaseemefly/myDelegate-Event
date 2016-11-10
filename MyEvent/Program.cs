using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEvent
{
    /// <summary>
    /// 打招呼委托
    /// </summary>
    /// <param name="name"></param>
    public delegate void GreetingDelegate(string name);

    public class GreetingManager
    {
        public void GreetPeople(string name,GreetingDelegate MakeGreeting)
        {
            MakeGreeting(name);
        }
    }

    public class GreetingManager1
    {
        public GreetingDelegate delegate1;
        public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        {
            
            MakeGreeting(name);
        }

        public void GreetPeoplebyDele(string name)
        {
            //若有方法注册委托变量
            if (delegate1 != null)
            {
                //通过委托调用方法
                delegate1(name);
            }
        }
    }

    class Program
    {
        private static void EnglishGreeting(string name)
        {
            Console.WriteLine("hello" + name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.WriteLine("你好" + name);
        }

        static void Main(string[] args)
        {
            //1 调用GreetingManager
            GreetingManager gm = new GreetingManager();
            gm.GreetPeople("drno", EnglishGreeting);
            gm.GreetPeople("小王", ChineseGreeting);

            //2 调用GreetingManager1（属性为委托）
            GreetingManager1 gm1 = new GreetingManager1();
            gm1.delegate1 = EnglishGreeting;
            gm1.delegate1 += ChineseGreeting;

            //gm1.GreetPeople("drno", gm1.delegate1);

            gm1.GreetPeoplebyDele("drno");

            Console.ReadKey();
        }
    }
}
