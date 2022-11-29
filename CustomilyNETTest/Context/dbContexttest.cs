using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using Npgsql;

namespace CustomilyNETTest.Context
{
    class NpgSqlConfiguration : DbConfiguration
    {
        public NpgSqlConfiguration()
        {
            var name = "Npgsql";

            SetProviderFactory(providerInvariantName: name,
                               providerFactory: NpgsqlFactory.Instance);

            SetProviderServices(providerInvariantName: name,
                                provider: NpgsqlServices.Instance);

            SetDefaultConnectionFactory(connectionFactory: new NpgsqlConnectionFactory());
        }
    }

    public class dbContexttest: DbContext
    {
       
        public dbContexttest(): base ("dbContexttest") { 
        
        }


        public DbSet<Models.Image> Image { get; set; }
        public DbSet<Models.Page> Page { get; set; }
        public DbSet<Models.Text> Text { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
           /* modelBuilder.Entity<Models.Image>().Property(p => p.X).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Models.Image>().Property(p => p.Y).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Models.Text>().Property(p => p.X).HasColumnType("decimal(18,4)");
            modelBuilder.Entity<Models.Text>().Property(p => p.X).HasColumnType("decimal(18,4)");*/
            base.OnModelCreating(modelBuilder);
        }

    }


}