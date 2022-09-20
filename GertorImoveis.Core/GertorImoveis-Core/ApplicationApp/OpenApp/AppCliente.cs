using ApplicationApp.Interfaces;
using Domain.Interface.InterfaceCliente;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationApp.OpenApp
{
    public class AppCliente : InterfaceClienteApp
    {
        ICliente _ICliente;
        IServiceCliente _IServiceCliente;
        public AppCliente(ICliente ICliente, IServiceCliente IServiceCliente)
        {
            _ICliente = ICliente;
            _IServiceCliente = IServiceCliente;

        }

        async Task InterfaceClienteApp.AddCliente(Cliente cliente)
        {
            await _IServiceCliente.AddCliente(cliente);
        }


        async Task InterfaceClienteApp.UpdateCliente(Cliente cliente)
        {
            await _IServiceCliente.UpdateCliente(cliente);
        }

        public async Task<List<Cliente>> ListarClientesUsuario(string pUserId)
        {
            return await _ICliente.ListarClientesUsuario(pUserId);
        }

        async Task InterfaceGenericsApp<Cliente>.Add(Cliente Objeto)
        {
            await _ICliente.Add(Objeto);
        }


        async Task InterfaceGenericsApp<Cliente>.Delete(Cliente Objeto)
        {
            await _ICliente.Delete(Objeto);
        }

        async Task<Cliente> InterfaceGenericsApp<Cliente>.GetEntityByID(int Id)
        {
           return await _ICliente.GetEntityByID(Id);
        }

       async Task<List<Cliente>> InterfaceGenericsApp<Cliente>.List()
        {
            return await _ICliente.List();
        }

        async Task InterfaceGenericsApp<Cliente>.Update(Cliente Objeto)
        {
            await _ICliente.Update(Objeto);
        }

       
    }
}
