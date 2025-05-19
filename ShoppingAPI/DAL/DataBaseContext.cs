using Microsoft.EntityFrameworkCore;
using ShoppingAPI.DAL.Entities;

namespace ShoppingAPI.DAL
{
    public class DataBaseContext:DbContext
    {

        public DataBaseContext(DbContextOptions<DataBaseContext>options):base(options)
        {



        }
        //configuraciones de la base de datos
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasIndex(c=> c.Name).IsUnique();//crear un indice unico para el campo name

        }
        //cada tabla por cada entidad crear sudbsts
        #region DbSets 

        public DbSet<Country> Countries { get; set; } 



        #endregion


    }
}

