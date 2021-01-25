using System;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Database database = new OracleServer();
            database.delete();
            database.add();
            Database database1 = new SqlServer();
            database1.add();
            database1.delete();
        }
    }
    abstract class deneme
    {
        void Add();
    }

    abstract class Database
    {
        public void add()
        {
            Console.WriteLine("Added by default");
        }
        public abstract void delete();
    }
    class SqlServer : Database
    {
        public override void delete()
        {
            Console.WriteLine("Deleted by sql");
        }
    }
    class OracleServer : Database
    {
        public override void delete()
        {
            Console.WriteLine("Deleted by oracle");
        }
    }
}
