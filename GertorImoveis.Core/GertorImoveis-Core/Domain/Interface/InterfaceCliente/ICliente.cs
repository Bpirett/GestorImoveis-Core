using Domain.Interface.Generics;
using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceCliente
{
    public interface ICliente : IGenerics<Cliente>
    {
        Task<List<Cliente>> ListarClientesUsuario(string pUserId);

    }
}
