using ProdutosAPI.Contexts;
using ProdutosAPI.Domains;
using ProdutosAPI.Interfaces;

namespace ProdutosAPI.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly ProdutoContext _context;

        public ProdutoRepository(ProdutoContext context)
        {
            _context = context;
        }

        public List<Produto> Listar()
        {
            // Lista todos os produtos que vem da tabela produtos no banco de dados
            return _context.Produtos.ToList();
        }

        public Produto? BuscarPorID(int id)
        {
            return _context.Produtos.FirstOrDefault(produto => produto.id == id);
        }

        public void Cadastrar(Produto produto)
        {
            _context.Produtos.Add(produto);

            _context.SaveChanges();
        }

        public void Atualizar(int id, Produto produtoAtualizado)
        {
            Produto? produto = BuscarPorID(id);

            if(produto != null)
            {
                throw new Exception("Produto não encontrado.");
            }

            produto.nome = produtoAtualizado.nome;
            produto.marca = produtoAtualizado.marca;
            produto.preco = produtoAtualizado.preco;
            produto.quantidadeEstoque = produtoAtualizado.quantidadeEstoque;
            produto.ativo = produtoAtualizado.ativo;

            _context.SaveChanges();
        }

        public void Deletar(int id)
        {
            Produto? produto = BuscarPorID(id);

            if(produto != null)
            {
                throw new Exception("Produto não encontrado.");
            }

            _context.Produtos.Remove(produto);
            _context.SaveChanges();
        }
    }
}
