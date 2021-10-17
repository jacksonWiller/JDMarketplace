using System;
using JDMarketplace.Domain.Compra;
using JDMarketplace.Domain.Entity.Produto;
using JDMarketplace.Domain.Entity.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JDMarketplace.Infraestructure.Data
{
    public class DataContext : IdentityDbContext<User, Role, Guid>
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options) {}
    
        public DbSet<Produto> Produtos {get;set;}
        public DbSet<Categoria> Categorias {get;set;}
        public DbSet<ProdutosCategorias> ProdutosCategorias {get;set;}
        public DbSet<Compra> Compras {get;set;}
        public DbSet<ItemPedido> ItemPedido {get;set;}
        
        protected override void OnModelCreating(ModelBuilder modelBuilder )
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ProdutosCategorias>()
                .HasKey(PC => new {PC.ProdutoId, PC.CategoriaId});


            modelBuilder.Entity<ItemPedido>()
                .HasKey(PC => new {PC.ProdutoId, PC.CompraId});
            
        }
    
    }
}