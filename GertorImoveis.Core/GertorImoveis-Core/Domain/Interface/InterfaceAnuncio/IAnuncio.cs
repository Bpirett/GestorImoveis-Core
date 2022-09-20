using Domain.Interface.Generics;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Domain.Interface.InterfaceAnuncio
{
    public interface IAnuncio : IGenerics<Anuncio>
    {
        Task<List<Anuncio>> ListarAnunciosUsuario(string pUserId);

        Task<List<Anuncio>> ListarAnunciosPublicados(Expression<Func<Anuncio, bool>> expAnuncio);

    }
}
