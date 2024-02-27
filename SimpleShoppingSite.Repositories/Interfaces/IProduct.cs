using SimpleShoppingSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleShoppingSite.Repositories.Interfaces
{
    public interface IProduct : IShare<Product>
    {
        int Count();
    }
}
