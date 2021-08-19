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
    public class DeleteCustomerHandler : IRequestHandler<DeleteCustomerCommand, DeleteResponse>
    {
        private readonly ICustomerRepository _customerRepo;
        public DeleteCustomerHandler(ICustomerRepository customerRepository)
        {
            _customerRepo = customerRepository;
        }
        public async Task<DeleteResponse> Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = await _customerRepo.GetByIdAsync(request.Id);
            if (customer != null)
            {
                await _customerRepo.DeleteAsync(customer);
            }
            return new DeleteResponse() { Message = "Ok" };
        }
    }
}
