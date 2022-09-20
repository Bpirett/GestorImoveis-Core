using Domain.Interface.InterfaceCliente;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceCliente : IServiceCliente
    {
        private readonly ICliente _ICliente;
        public ServiceCliente(ICliente ICliente)
        {
            _ICliente = ICliente;
        }


        async Task IServiceCliente.AddCliente(Cliente cliente)
        {
            var validaNome = cliente.ValidarPropriedadeString(cliente.Nome, "Nome");

            if (validaNome)
            {
                cliente.DataCadastro = DateTime.Now;
                cliente.DataAlteracao = DateTime.Now;
                await _ICliente.Add(cliente);
            }
          
        }

        async Task IServiceCliente.UpdateCliente(Cliente cliente)
        {
            var validaNome = cliente.ValidarPropriedadeString(cliente.Nome, "Nome");
            
            if (validaNome)
            {
                cliente.DataAlteracao = DateTime.Now;
                await _ICliente.Update(cliente);
            }
            
        }
    }
}
