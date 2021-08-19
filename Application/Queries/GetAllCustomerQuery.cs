﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries
{
    public class GetAllCustomerQuery : IRequest<List<Core.Entities.Customer>>
    {
    }
}
