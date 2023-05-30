using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contatos_Eletronicos.Models
{
    [Table("Enderecos")]
    public class Endereco
    {
        [Key]
        public int EnderecoId { get; set; }

        [Required(ErrorMessage = "A rua deve Ser Informado")]
        [MaxLength(80, ErrorMessage = "A rua deve ter no maximo {1} caracteres")]
        [Display(Name = "Rua Do Cliente")]
        public string  Rua { get; set; }

        [Required(ErrorMessage = "A Numero deve Ser Informado")]
        [Display(Name = "Numero Do Cliente")]
        public int Numero { get; set; }

        [Required(ErrorMessage = "A Cep deve Ser Informado")]
        [MaxLength(80, ErrorMessage = "A Cep deve ter no maximo {1} caracteres")]
        [Display(Name = "Cep Do Cliente")]
        public string Cep { get; set; }

        [Required(ErrorMessage = "O Bairro deve Ser Informado")]
        [MaxLength(80, ErrorMessage = "O Bairro deve ter no maximo {1} caracteres")]
        [Display(Name = "Bairro Do Cliente")]
        public string Bairro { get; set; }


        //Chave estrangeira
        //public int ClienteID { get; set; }
        //public virtual Cliente Cliente{ get; set; }
    }
}
