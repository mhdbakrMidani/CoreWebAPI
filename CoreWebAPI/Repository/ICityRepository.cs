using CoreWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreWebAPI.Repository
{
    public interface ICityRepository
    {
        Task<IEnumerable<City>> Get();
        Task<City> Get(int id);
        Task<City> Create(City city);
        Task Update(City city);
        Task Delete(int id);
    }
}
