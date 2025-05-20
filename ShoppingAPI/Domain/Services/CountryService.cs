using Microsoft.EntityFrameworkCore;
using ShoppingAPI.DAL;
using ShoppingAPI.DAL.Entities;
using ShoppingAPI.Domain.Interfaces;

namespace ShoppingAPI.Domain.Services
{
  
        public class CountryServices : ICountryService
        {
            private readonly DataBaseContext _context;
            public CountryServices(DataBaseContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Country>> GetCountriesAsync()
            {
                try
                {
                    var countries = await _context.Countries.ToListAsync();
                    return countries;
                }
                catch (DbUpdateException dbUpdateException)
                {
                    throw new Exception(dbUpdateException.InnerException?.Message ??
                        dbUpdateException.Message);
                }
            }

            public async Task<Country> GetCountryByIdAsync(Guid id)
            {

                try
                {
                    var country = await _context.Countries.FirstOrDefaultAsync(c => c.Id == id);
                    return country;
                }
                catch (DbUpdateException dbUpdateException)
                {
                    throw new Exception(dbUpdateException.InnerException?.Message ??
                        dbUpdateException.Message);
                }
            }

            public async Task<Country> CreateCountryAsync(Country country)
            {
                try
                {
                    country.Id = Guid.NewGuid();
                    country.CreatedDate = DateTime.Now;
                    _context.Countries.Add(country); //El metodo Add() me permite crear el objeto en el contexto de mi BD

                    await _context.SaveChangesAsync();// Este metodo me permite guardar el pais en mi tabla COUNTRY

                    return country;

                }
                catch (DbUpdateException dbUpdateException)
                {
                    throw new Exception(dbUpdateException.InnerException?.Message ??
                        dbUpdateException.Message);
                }

            }

            public async Task<Country> EditCountryAsync(Country country)
            {
                try
                {
                    country.ModifiedDate = DateTime.Now;
                    _context.Countries.Update(country);// Virtualizo mi objeto
                    await _context.SaveChangesAsync();
                    return country;
                }
                catch (DbUpdateException dbUpdateException)
                {
                    throw new Exception(dbUpdateException.InnerException?.Message ??
                        dbUpdateException.Message);
                }
            }

            public async Task<Country> DeleteCountryAsync(Guid id)
            {
                try
                {
                    var country = await GetCountryByIdAsync(id);
                    if (country == null)
                    {
                        return null;
                    }
                    _context.Countries.Remove(country);
                    await _context.SaveChangesAsync();

                    return country;
                }
                catch (DbUpdateException dbUpdateException)
                {
                    throw new Exception(dbUpdateException.InnerException?.Message ??
                        dbUpdateException.Message);
                }
            }
        }
    }