using ProdutosAPI.Domains;

namespace ProdutosAPI.Interfaces
{
    public interface IProdutoRepository
    {
        List<Produto> Listar();
        Produto BuscarPorID(int ID);

        void Cadastrar(Produto produto);

        void Atualizar(int id, Produto produto);

        void Deletar(int id);
    }

}
