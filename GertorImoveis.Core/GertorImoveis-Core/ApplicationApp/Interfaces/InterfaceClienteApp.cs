using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceClienteApp : InterfaceGenericsApp<Cliente>
    {
        Task AddCliente(Cliente cliente);

        Task UpdateCliente(Cliente cliente);

        Task<List<Cliente>> ListarClientesUsuario(string pUserId);



    }
}
