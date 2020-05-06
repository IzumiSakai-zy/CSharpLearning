using System;

namespace EventHanderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Phone phone = new Phone();
            Person person = new Person();
            phone.Ring += person.handlerRing;
            phone.messageCome();
        }
    }

    public class RingEventArgs : EventArgs
    {
        public string ringType { get; set; }
    }

    public class Phone
    {
        public event EventHandler Ring;
        
        public void messageCome()
        {
            if (this.Ring != null)
                Ring(this, new RingEventArgs() { ringType = "Wechat" });
        }
    }

    public class Person
    {
        internal void handerRing(Phone phone, RingEventArgs e)
        {
            switch (e.ringType)
            {
                case "QQ":
                    Console.WriteLine("来QQ消息了");
                    break;
                case "Wechat":
                    Console.WriteLine("来微信消息了");
                    break;
                default:
                    Console.WriteLine("来其他消息了");
                    break;
            }
        }

        internal void handlerRing(object sender, EventArgs e)
        {
            RingEventArgs ringEventArgs = e as RingEventArgs;
            switch (ringEventArgs.ringType)
            {
                case "QQ":
                    Console.WriteLine("来QQ消息了");
                    break;
                case "Wechat":
                    Console.WriteLine("来微信消息了");
                    break;
                default:
                    Console.WriteLine("来其他消息了");
                    break;
            }
        }
    }
}
