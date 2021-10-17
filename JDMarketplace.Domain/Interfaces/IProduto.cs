using System;
using System.Threading.Tasks;
using JDMarketplace.Domain.Entity.Produto;

namespace JDMarketplace.Domain.Interfaces
{
    public interface IProduto
    {
        Task addProdutosAsync(Produto produto);

        //PRODUTOS
        Task<Produto[]> GetAllProdutosAsync();
        Task<Produto[]> GetAllProdutosAsyncByNome( string nome);
        Task<Produto> GetProdutoAsyncById(Guid ProdutosId);
    }
}