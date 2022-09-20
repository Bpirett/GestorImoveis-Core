using Domain.Interface.InterfaceAnuncio;
using Domain.Interface.InterfaceCliente;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryAnuncio : RepositoryGenerics<Anuncio>, IAnuncio
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilser;
        public RepositoryAnuncio()
        {
            _optionsBuilser = new DbContextOptions<ContextBase>();
        }

        public async Task<List<Anuncio>> ListarAnunciosPublicados(Expression<Func<Anuncio, bool>> expAnuncio)
        {
            using (var db = new ContextBase(_optionsBuilser))
            {
                return await db.Anuncios.Where(expAnuncio).AsNoTracking().ToListAsync();
            }
        }

        public async Task<List<Anuncio>> ListarAnunciosUsuario(string pUserId)
        {
            using (var db = new ContextBase(_optionsBuilser))
            {
                return await db.Anuncios.Where(p => p.UserId == pUserId).AsNoTracking().ToListAsync();
            }
        }
    }
}
