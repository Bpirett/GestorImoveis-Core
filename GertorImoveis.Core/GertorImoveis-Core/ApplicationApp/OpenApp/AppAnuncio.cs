using ApplicationApp.Interfaces;
using Domain.Interface.InterfaceAnuncio;
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
    public class AppAnuncio : InterfaceAnuncioApp
    {

        IAnuncio _IAnuncio;
        IServiceAnuncio _IServiceAnuncio;
        public AppAnuncio(IAnuncio  IAnuncio, IServiceAnuncio IServiceAnuncio)
        {
            _IAnuncio = IAnuncio;
            _IServiceAnuncio = IServiceAnuncio;

        }

        public async Task Add(Anuncio Objeto)
        {
            await _IAnuncio.Add(Objeto);
        }

        public async Task AddAnuncio(Anuncio anuncio)
        {
            await _IServiceAnuncio.AddAnuncio(anuncio);
        }

        public async Task Delete(Anuncio Objeto)
        {
            await _IAnuncio.Delete(Objeto);
        }

        public async Task<Anuncio> GetEntityByID(int Id)
        {
            return await _IAnuncio.GetEntityByID(Id);
        }

         async Task<List<Anuncio>> InterfaceGenericsApp<Anuncio>.List()
        {
            return await _IAnuncio.List();
        }

        public async Task<List<Anuncio>> ListarAnunciosUsuario(string pUserId)
        {
            return await _IAnuncio.ListarAnunciosUsuario(pUserId);
        }

        async Task InterfaceGenericsApp<Anuncio>.Update(Anuncio Objeto)
        {
            await _IAnuncio.Update(Objeto);
        }

        async Task InterfaceAnuncioApp.UpdateAnuncio(Anuncio anuncio)
        {
            await _IServiceAnuncio.UpdateAnuncio(anuncio);
        }

        public async Task<List<Anuncio>> ListarAnunciosPublicados()
        {
            return await _IServiceAnuncio.ListarAnunciosPublicados();
        }
    }
}
