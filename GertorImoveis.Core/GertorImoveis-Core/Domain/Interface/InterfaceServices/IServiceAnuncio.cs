using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceServices
{
    public interface IServiceAnuncio
    {

        Task AddAnuncio(Anuncio anuncio);

        Task UpdateAnuncio(Anuncio anuncio);

        Task<List<Anuncio>> ListarAnunciosPublicados();

    }
}
