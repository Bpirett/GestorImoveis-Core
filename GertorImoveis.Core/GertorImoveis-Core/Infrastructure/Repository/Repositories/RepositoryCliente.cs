using Domain.Interface.InterfaceCliente;
using Entities.Entities;
using Infrastructure.Configuration;
using Infrastructure.Repository.Generics;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Repositories
{
    public class RepositoryCliente : RepositoryGenerics<Cliente>, ICliente
    {
        private readonly DbContextOptions<ContextBase> _optionsBuilser;
        public RepositoryCliente()
        {
            _optionsBuilser = new DbContextOptions<ContextBase>();
        }


        public async Task<List<Cliente>> ListarClientesUsuario(string pUserId)
        {
            using (var db = new ContextBase(_optionsBuilser))
            {
                return await db.Clientes.Where(p => p.UserId == pUserId).AsNoTracking().ToListAsync();
            }
        }
    }
}
