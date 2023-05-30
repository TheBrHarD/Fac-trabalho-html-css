using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contatos_Eletronicos.Models
{
    [Table("Carrinho")]
    public class Carrinho
    {
        [Key]
        public int CarrinhoId { get; set; }


        [Required(ErrorMessage = "A Quantidade deve Ser Informado")]
        [Display(Name = "Quantidade Do Produto")]
        public int Quantidade{ get; set; }

        [Display(Name = "Valor total")]
        public float Valor_Pagar { get; set; }

        [Required(ErrorMessage = "A Forma de Pagamento deve Ser Informado")]
        public string Forma_Pagamento { get; set; }

        [StringLength(200)]
        public string CarrinhoCompraId { get; set; }

        //Chave estrangeira 1
        //public int VendaId { get; set; }
        //public virtual Venda Venda{ get; set; }

        //Chave estrangeira N
        public List<Produto> Produto{ get; set; }
    }
}
