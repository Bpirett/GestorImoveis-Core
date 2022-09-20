using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices
{
    public interface IServiceCliente
    {

        Task AddCliente(Cliente cliente);

        Task UpdateCliente(Cliente cliente);


    }
}
