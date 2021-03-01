using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection
{
    public interface ICustomerService
    {

        string Uid { get; set; }
        Customer GetCustomerById(int id);

    }
}
