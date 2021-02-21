using System;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            //DortIslem dortIslem = new DortIslem(2, 3);
            //Console.WriteLine(dortIslem.Topla2());
            //Console.WriteLine(dortIslem.Topla(3, 4));

            var type = typeof(DortIslem);
            //DortIslem dortislem = (DortIslem)Activator.CreateInstance(type, 6, 7);
            //Console.WriteLine(dortislem.Topla(4, 5));
            //Console.WriteLine(dortislem.Topla2());
            var instance = Activator.CreateInstance(type, 6, 7);
            MethodInfo methodInfo = instance.GetType().GetMethod("Topla2");
            Console.WriteLine(methodInfo.Invoke(instance, null));


            var methods = type.GetMethods();
            foreach (var info in methods)
            {
                Console.WriteLine("Method adi :{0}", info.Name);
                foreach (var parametreInfo in info.GetParameters())
                {
                    Console.WriteLine("Parametre adi : {0}", parametreInfo.Name);
                }
                foreach (var Upper in info.GetCustomAttributes())
                {
                    Console.WriteLine("Parametre adi : {0}", Upper.GetType());
                }
            }


        }
    }
    class DortIslem
    {
        private int _s1;
        private int _s2;
        public DortIslem(int s1, int s2)
        {
            _s1 = s1;
            _s2 = s2;
        }
        public DortIslem()
        {

        }
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }
        public int Topla2()
        {
            return _s1 + _s2;
        }
        [MethodName("Carpma")]
        public int Carp2()
        {
            return _s1 * _s2;
        }



    }
    class MethodNameAttribute : Attribute
    {
        public MethodNameAttribute(string name)
        {

        }
    }
}
