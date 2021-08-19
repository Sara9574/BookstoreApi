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
    public class UpdateCustomerHandler : IRequestHandler<UpdateCustomerCommand, CustomerResponse>
    {
        private readonly ICustomerRepository _customerRepo;
        public UpdateCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public async Task<CustomerResponse> Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            //var customerEntitiy = CustomerMapper.Mapper.Map<Core.Entities.Customer>(request);
            //if (customerEntitiy is null)
            //{
            //    throw new ApplicationException("Issue with mapper");
            //}
            var customer = await _customerRepo.GetByIdAsync(request.Id);
            if (customer != null)
            {
                customer.Mobile = request.Mobile;
                customer.FullName = request.FullName;
                customer.Password = request.Password;
                customer.DateOfBirth = request.DateOfBirth;
                customer.UpdateDate = DateTime.Now;
            }
            await _customerRepo.UpdateAsync(customer);
            var customerResponse = CustomerMapper.Mapper.Map<CustomerResponse>(customer);
            return customerResponse;
        }
    }
}
