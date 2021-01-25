using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    interface ICustomerDal
    {
        void add();
        void update();
        void delete();
    }
    class SqlServerCustomerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("Sql added");
        }

        public void delete()
        {
            Console.WriteLine("Sql deleted");
        }

        public void update()
        {
            Console.WriteLine("Sql updated");
        }
    }
    class OracleServerCustomerDal : ICustomerDal
    {
        public void add()
        {
            Console.WriteLine("Oracle added");
        }

        public void delete()
        {
            Console.WriteLine("Oracle deleted");

        }

        public void update()
        {
            Console.WriteLine("Oracle updated");

        }
    }

    class CustomerManager
    {
        public void add(ICustomerDal customerDal)
        {
            customerDal.add();

        }
    }
}
