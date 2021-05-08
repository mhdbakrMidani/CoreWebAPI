using CoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Repository
{
    public class CityRepository : ICityRepository
    {
        private readonly worldContext _context;

        public CityRepository(worldContext context)
        {
            _context = context;
        }
        public async Task<City> Create(City city)
        {
            _context.Cities.Add(city);
            await _context.SaveChangesAsync();
            return city;
        }

        public async Task Delete(int id)
        {
            var cityToDelete = _context.Cities.FindAsync(id);
            _context.Cities.Remove(await cityToDelete);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<City>> Get()
        {
            return await _context.Cities.ToListAsync();
        }

        public async Task<City> Get(int id)
        {
            return await _context.Cities.FindAsync(id);
        }

        public async Task Update(City city)
        {
            _context.Entry(city).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }
    }
}
