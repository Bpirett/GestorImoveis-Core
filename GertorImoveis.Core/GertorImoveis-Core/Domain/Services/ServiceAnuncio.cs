using Domain.Interface.InterfaceAnuncio;
using Domain.Interface.InterfaceServices;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class ServiceAnuncio : IServiceAnuncio
    {
        private readonly IAnuncio _IAnuncio;
        public ServiceAnuncio(IAnuncio IAnuncio)
        {
            _IAnuncio = IAnuncio;
        }

        public async Task<List<Anuncio>> ListarAnunciosPublicados()
        {
            return await _IAnuncio.ListarAnunciosPublicados(p=>p.Ativo == "S");
        }

        async Task IServiceAnuncio.AddAnuncio(Anuncio anuncio)
        {
            anuncio.DataCadastro = DateTime.Now;
            anuncio.DataAtualizacao = DateTime.Now;
            await _IAnuncio.Add(anuncio);
        }

        async Task IServiceAnuncio.UpdateAnuncio(Anuncio anuncio)
        {
            anuncio.DataAtualizacao = DateTime.Now;
            await _IAnuncio.Update(anuncio);
        }
    }
}
