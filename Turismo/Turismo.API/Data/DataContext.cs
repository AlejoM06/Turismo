using Turismo.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Turismo.API.Data
{
    public class DataContext : DbContext
   
        {
            //Utilizar las propiedades y opciones de DBContext
            public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        
        }       
        

        public DbSet <City> Cities   { get; set; } 


        protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

    }
}

