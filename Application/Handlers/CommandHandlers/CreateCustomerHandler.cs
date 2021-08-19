using Application.Commands;
using Application.Mappers;
using Application.Responses;
using Core.Repositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.CommandHandlers
{
    public class CreateCustomerHandler: IRequestHandler<CreateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerRepository _customerRepo;
        public CreateCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public async Task<CustomerResponse> Handle(CreateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customerEntitiy = CustomerMapper.Mapper.Map<Core.Entities.Customer>(request);
            if (customerEntitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }
            var newCustomer = await _customerRepo.AddAsync(customerEntitiy);
            var customerResponse = CustomerMapper.Mapper.Map<CustomerResponse>(newCustomer);
            return customerResponse;
        }
    }
}
