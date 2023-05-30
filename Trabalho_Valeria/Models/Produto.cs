using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_Valeria.Models
{
    [Table("Produtos")]
    public class Produto
    {
        [Key]
        public int ProdutoId { get; set; }

        [Required(ErrorMessage = "O nome do produto deve ser informado")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no maximo {1} caracteres")]
        [Display(Name = "Nome do produto")]
        public string NomeProduto { get; set; }

        [Required(ErrorMessage = "O preço do produto deve ser informado")]
        [Display(Name = "Preço do produto")]
        [Column(TypeName = "decimal(10,2)")]
        [Range(1, 999.99, ErrorMessage = "O preço do lanche deve estar entre R$ 1,00 e R$ 999,99")] 
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "A descrição do produto deve ser informado")]
        [MinLength(10, ErrorMessage = "A descrição deve ter no mínimo {1} caracteres")]
        [MaxLength(100, ErrorMessage = "A descrição deve ter no maximo {1} caracteres")]
        [Display(Name = "Descrição do Produto")]
        public string DescricaoProduto { get; set; }

        public string ImagemUrl { get; set; }

        //Relacioanemnto de 1 
        public int EstoqueId { get; set; }
        public virtual Estoque Estoque { get; set; }

        //relacionament de N
        //public List<Carrinho> Carrinho{ get; set; }
        
    }
}
