using System;
using System.Linq;
using System.Threading.Tasks;
using JDMarketplace.Domain.Entity.Produto;
using JDMarketplace.Domain.Interfaces;
using JDMarketplace.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;

namespace JDMarketplace.Infraestructure.Repository
{
    public class RepositoryProduto : IProduto
    {
        public readonly DataContext _dataContext;

        public RepositoryProduto(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task addProdutosAsync(Produto produto){
            await _dataContext.Produtos.AddAsync(produto);
            foreach (var produtosCategorias in produto.ProdutosCategorias)
            {
                await _dataContext.ProdutosCategorias.AddAsync(produtosCategorias);
            } 
            await _dataContext.SaveChangesAsync();
        }
        public async Task<Produto[]> GetAllProdutosAsync()
        {
            IQueryable<Produto> query = _dataContext.Produtos;
               
            query = query.AsNoTracking().OrderBy(p => p.Id)
            .Include(pc => pc.ProdutosCategorias);

            return await query.ToArrayAsync();
        }
        public async Task<Produto[]> GetAllProdutosAsyncByNome(string nome)
        {
            IQueryable<Produto> query = _dataContext.Produtos;
            
             query = query.AsNoTracking().OrderBy(e => e.Id)
                         .Where(e => e.Nome.ToLower().Contains(nome.ToLower()));

            return await query.ToArrayAsync();

        }

         public async Task<Produto> GetProdutoAsyncById(Guid ProdutoId)
        {
            IQueryable<Produto> query = _dataContext.Produtos;

            query = query.AsNoTracking().OrderBy(e => e.Id)
                         .Where(e => e.Id == ProdutoId);

            return await query.FirstOrDefaultAsync();
        }

    }
}