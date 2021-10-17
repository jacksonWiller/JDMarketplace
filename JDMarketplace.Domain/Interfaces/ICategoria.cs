using System;
using System.Threading.Tasks;
using JDMarketplace.Domain.Entity.Produto;

namespace JDMarketplace.Domain.Entity.Interfaces
{
    public interface ICategoria
    {
        //PRODUTOS
        Task<Categoria[]> GetAllCategoriasAsync();
        Task<Categoria[]> GetAllCategoriasAsyncByNome( string nome);
        Task<Categoria> GetCategoriasAsyncById(Guid CategoriaId);
    }
}