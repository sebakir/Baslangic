using System.Collections.Generic;

namespace Generics
{
    partial class Program
    {
        public interface ICustomerDal : IRepository<Customer>
        {

        }
    }
}
