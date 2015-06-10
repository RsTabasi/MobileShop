using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using MvcModel;

namespace DataLayer.Context
{
    class MyProjectContext : DbContext
    {
        static MyProjectContext()
        {
            Database.SetInitializer<MyProjectContext>(new CreateDatabaseIfNotExists<MyProjectContext>());
        }
        public MyProjectContext()
        {

        }

        public DbSet<User> users { get; set; }
        public DbSet<Bank> banks { get; set; }
        public DbSet<Brand> brands { get; set; }
        public DbSet<Comment> comments { get; set; }
        public DbSet<News> news { get; set; }
        public DbSet<NewsType> newsTypes { get; set; }
        public DbSet<Picture> pictures { get; set; }
        public DbSet<PictureType> pctureTypes { get; set; }
        public DbSet<Post> posts { get; set; }
        public DbSet<Product> products { get; set; }
        public DbSet<Role> roles { get; set; }
        public DbSet<SaleDoc> saleDocs { get; set; }
        public DbSet<ShopDoc> shopDocs { get; set; }
        public DbSet<Store> stores { get; set; }
        public DbSet<StoreType> storeTypes { get; set; }
        public DbSet<Transaction> transactions { get; set; }
        public DbSet<Transport> transports { get; set; }
        public DbSet<User> users { get; set; }

    }
    
    
}
