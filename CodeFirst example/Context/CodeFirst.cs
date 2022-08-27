using CodeFirst_example.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst_example.Context {
    public class CodeFirst : DbContext{
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Deposito> Depositos { get; set; }
        public DbSet<Sucursal> Sucursales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            
            optionsBuilder.UseSqlServer("Server=JEREMIASNOTE\\SQLEXPRESS;Initial Catalog=CodeFirstExample;Integrated Security=True;");
            
            base.OnConfiguring(optionsBuilder);
        }
    }
}
