using System;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        public delegate void MyDelegate2(string text);
        public delegate void MyDelegate3(int n1, int n2);


        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            //customerManager.SendMessage();
            //customerManager.ShowAlert();
            // you should think like  cooking
            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate();
            myDelegate -= customerManager.SendMessage;
            myDelegate();
            MyDelegate2 myDelegate2 = customerManager.SendMessage2;
            myDelegate2("selam kanks");
            Mat matematik = new Mat();
            //MyDelegate3 myDelegate3 = matematik.Topla;
            //var result = myDelegate3(2, 3);
            //Console.WriteLine(result);
        }
        public class CustomerManager
        {
            public void SendMessage()
            {
                Console.WriteLine("Hello");
            }
            public void ShowAlert()
            {
                Console.WriteLine("Be careful!!!");
            }
            public void SendMessage2(string message)
            {
                Console.WriteLine(message);
            }
            public void ShowAler2t(string message)
            {
                Console.WriteLine(message);
            }
        }
        public class Mat
        {
            public int Topla(int s1, int s2)
            {
                return s1 + s2;
            }
            public int Topla2(int s1, int s2)
            {
                return s1 + s2;
            }
        }
    }
}
