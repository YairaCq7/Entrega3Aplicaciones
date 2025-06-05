using ShoppingAPI.DAL;
using ShoppingAPI.DAL.Entities;

namespace ShoppingAPI.DAL
{
    public class SeederDB
   
    {
        private readonly DataBaseContext _context;

        public SeederDB(DataBaseContext context)
        {
            _context = context;
        }

        //Crearemos un metodo llamado SeederAsync
        //Este metodo es una especie de Main
        //Este metodo tendra la responsabilidad de prepoblar mis diferentes tablas de la BD

        public async Task SeederAsync()
        {
            //Primero: agregare un metodo propio de EF que hace las veces del comando 'update-database'
            //Creara la BD inmediatamente ponga en ejecucion la api
            await _context.Database.EnsureCreatedAsync();

            //A partir de aqui crearemos metodos para prepoblar la BD
            await PopulateCountriesAsync();

            await _context.SaveChangesAsync();
        }

        #region private Methos
        private async Task PopulateCountriesAsync()
        {
            if (!_context.Countries.Any())
            {
                //Asi creo un objeto pais con sus estados
                _context.Countries.Add(new Country
                {
                    CreatedDate = DateTime.Now,
                    Name = "Colombia",
                    States = new List<State>()
                    {
                        new State
                        {
                            CreatedDate = DateTime.Now,
                            Name = "Antioquia"
                        },

                        new State
                        {
                            CreatedDate = DateTime.Now,
                            Name = "Cundinamarca"
                        }
                    }

                });

                _context.Countries.Add(new Country
                {
                    CreatedDate = DateTime.Now,
                    Name = "Argentina",
                    States = new List<State>()
                    {
                        new State
                        {
                            CreatedDate = DateTime.Now,
                            Name = "Buenos Aires"
                        }
                    }

                });

            }
        }
        #endregion
    }
}