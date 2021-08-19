using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Responses
{
    public class CustomerResponse
    {
        public string FullName { get; set; }
        public string Mobile { get; set; }
        public string Password { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
