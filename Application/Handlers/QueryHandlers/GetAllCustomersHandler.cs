using Application.Queries;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.QueryHandlers
{
    public class GetAllCustomersHandler : IRequestHandler<GetAllCustomerQuery, List<Core.Entities.Customer>>
    {
        private readonly ICustomerRepository _customerRepo;
        public GetAllCustomersHandler(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public async Task<List<Core.Entities.Customer>> Handle(GetAllCustomerQuery request, CancellationToken cancellationToken)
        {
            return (List<Core.Entities.Customer>)await _customerRepo.GetAllAsync();
        }
    }
}