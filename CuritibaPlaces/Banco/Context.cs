using CuritibaPlaces.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    public class Context : DbContext
    {
        public Context() : base("strConn"){
            Database.SetInitializer(new DropCreateDatabaseIfModelChanges<Context>);
        }

        public DbSet<User> Users { get; set; }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public  DbSet<Endereco> Enderecos { get; set; }

        public  DbSet<Place> Places { get; set; }

        
    }
}
