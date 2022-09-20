using Entities.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ApplicationApp.Interfaces
{
    public interface InterfaceAnuncioApp : InterfaceGenericsApp<Anuncio>
    {

        Task AddAnuncio(Anuncio anuncio);

        Task UpdateAnuncio(Anuncio anuncio);

        Task<List<Anuncio>> ListarAnunciosUsuario(string pUserId);


        Task<List<Anuncio>> ListarAnunciosPublicados();
    }
}
