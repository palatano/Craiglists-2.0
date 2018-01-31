using System;
using System.Data.Entity;
using System.Linq;
using Demo.Model;

namespace BL
{

    public class DALContext : DbContext
    {
        // Your context has been configured to use a 'DALContext' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'BL.DALContext' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DALContext' 
        // connection string in the application configuration file.
        public DALContext()
            : base("name=CraigslistDB")
        { 
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        public virtual DbSet<Review> Reviews { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
    
}