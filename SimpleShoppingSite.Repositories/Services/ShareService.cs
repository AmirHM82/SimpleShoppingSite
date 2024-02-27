using SimpleShoppingSite.Models;
using SimpleShoppingSite.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShoppingSite.Repositories.Services
{
    public class ShareService<T> : IShare<T> where T : BaseModel
    {
        public Task<T> AddAsync(T model)
        {
            throw new NotImplementedException();
        }

        public List<T> GetAllAsync(int page, int numberOfItems)
        {            
            throw new NotImplementedException();
        }

        public Task SaveAsync(T model)
        {
            throw new NotImplementedException();
        }
    }
}
