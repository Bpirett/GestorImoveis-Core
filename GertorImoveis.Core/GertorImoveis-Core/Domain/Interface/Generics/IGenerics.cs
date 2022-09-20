using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interface.Generics
{
    public interface IGenerics<T> where T : class
    {

        Task Add(T Objeto);
        Task Update(T Objeto);
        Task Delete(T Objeto);
        Task<T> GetEntityByID(int Id);
        Task<List<T>> List();

    }
}
