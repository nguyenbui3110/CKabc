using CK.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace CK.Entity
{
    public class QLDiem : DbContext
    {
        // Your context has been configured to use a 'QLDiem' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'CK.Entity.QLDiem' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'QLDiem' 
        // connection string in the application configuration file.
        public QLDiem()
            : base("name=QLDiem")
        {
            Database.SetInitializer<QLDiem>(new createDB());

        }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<SV> SVs { get; set; }
        public virtual DbSet<HocPhan_SV> HocPhan_SVs { get; set; }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}