using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace PostureRepo.Repository_and_BO.Client
{
    class Client: DbContext
    {
        public DbSet<Client> MyProperty { get; set; }
    }
}
