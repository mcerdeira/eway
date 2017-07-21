using _eway.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace _eway.DAL
{
    public class CatalogoContext : DbContext
    {
        public CatalogoContext()
            : base("CatalogoContext")
        { }

        public DbSet<Producto> Producto { get; set; }
        public DbSet<ProductoCelular> ProductoCelular { get; set; }
        public DbSet<ProductoAireAcondicionado> ProductoAireAcondicionado { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}