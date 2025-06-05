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
            modelBuilder.Entity<Country>().HasIndex(c => c.Name).IsUnique();//crear un indice unico para el campo name

            modelBuilder.Entity<State>().HasIndex("Name", "CountryId").IsUnique();
        }

        #region DbSets
        public DbSet<Country> Countries { get; set; }
        public DbSet<State> States { get; set; }
     




        #endregion


    }
}

