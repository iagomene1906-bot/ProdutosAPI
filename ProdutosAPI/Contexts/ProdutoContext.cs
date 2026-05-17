using Microsoft.EntityFrameworkCore;
using ProdutosAPI.Domains;

namespace ProdutosAPI.Contexts
{
    public class ProdutoContext : DbContext
    {
        public ProdutoContext(DbContextOptions<ProdutoContext> options) : base(options)
        {
        }

        // DbSet -> "Crie uma tabela produtos na classe produtos"
        public DbSet<Produto> Produtos { get; set; }
    }

}
