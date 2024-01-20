using FinancasApp.Infra.Data.Mappings;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancasApp.Infra.Data.Contexts
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
            optionsBuilder.UseSqlServer(@"Data Source=SQL5110.site4now.net;Initial Catalog=db_aa1ac9_bdfinancasapp;User Id=db_aa1ac9_bdfinancasapp_admin;Password=coti1234

");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        
            modelBuilder.ApplyConfiguration(new UsuarioMap());
            modelBuilder.ApplyConfiguration(new PerfilMap());
            modelBuilder.ApplyConfiguration(new CategoriaMap());
            modelBuilder.ApplyConfiguration(new MovimentacaoMap());
        }
    }
}



