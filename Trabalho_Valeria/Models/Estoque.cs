using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Trabalho_Valeria.Models
{
    [Table("Estoques")]
    public class Estoque
    {
        [Key]
        public int EstoqueId { get;  set; }



        [Required(ErrorMessage = "A Quantidade deve Ser Informado")]
        [Display(Name = "Quantidade Do Produto")]
        public int Quantidade { get; set; }


        //Relacioanemnto de 1 
        //public int ProdutoId { get; set; }
        //public virtual Produto Produto { get; set; }
    }
}
