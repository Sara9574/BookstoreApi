using Core.Entities;
using Core.Repositories;
using Infrastructure.Data;
using Infrastructure.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(BookstoreContext booksotreContext) : base(booksotreContext)
        {
        }
        public async Task<IEnumerable<Customer>> GetCustomerByUsername(string username)
        {
            return await _booksotreContext.Customers.Where(x => x.Mobile == username).ToListAsync();
        }
    }
}
