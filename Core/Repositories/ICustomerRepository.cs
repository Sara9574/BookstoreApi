using Core.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Repositories
{
    public interface ICustomerRepository : IRepository<Entities.Customer>
    {
        Task<IEnumerable<Entities.Customer>> GetCustomerByUsername(string username);
    }
}
