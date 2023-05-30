using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Trabalho_Valeria.Models;

namespace Trabalho_Valeria.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        //selecionar quais classes eu quero que vá para o banco -Migrations
        // public DbSet<Cliente> Clientes{ get; set; }
        // public DbSet<Endereco> Enderecos{ get; set; }
        public DbSet<Estoque> Estoques{ get; set; }
        public DbSet<Produto> Produtos{ get; set; }
        public DbSet<Venda> Vendas{ get; set; }
        public DbSet<VendaDetalhe> VendasDetalhe { get; set; }
        public DbSet<CarrinhoCompraItem> CarrinhoCompraItens { get; set; }
    }

}
