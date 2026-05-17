using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProdutosAPI.Domains
{
    public class Produto
    {
        // Esse atributo é uma chave primária no banco de dados
        [Key]
        public int id { get; set; }

        // Todos os campos precisam ser obrigatórios
        [Required]
        public string nome { get; set; } = string.Empty;

        [Required]
        public string marca { get; set; } = string.Empty;

        [Required]
        // decimal(10,2) -> podemos ter até 10 números armazenados, sendo eles 2 depois da vírgula
        [Column(TypeName = "decimal(10,2)")]
        public decimal preco { get; set; }

        public int quantidadeEstoque {  get; set; }

        public bool ativo { get; set; } = true;
    }

}
