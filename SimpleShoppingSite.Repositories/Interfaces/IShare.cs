using SimpleShoppingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShoppingSite.Repositories.Interfaces
{
    public interface IShare<T> where T : BaseModel
    {
        Task<T> AddAsync(T model);
        Task SaveAsync(T model);
        List<T> GetAllAsync(int page, int numberOfItems);
    }
}
