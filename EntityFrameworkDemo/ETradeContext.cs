using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    class ETradeContext : DbContext
    {
        //Bir productı tablo gibi kullanmak
        public DbSet<Product> Products { get; set; }

    }
}
