using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Contatos_Eletronicos.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [Required(ErrorMessage = "O nome deve Ser Informado")]
        [MaxLength(80, ErrorMessage = "O nome deve ter no maximo {1} caracteres")]
        [Display(Name = "Nome Do Cliente")]
        public string NomeCliente { get; set; }

        [MaxLength(15, ErrorMessage = "O nome deve ter no maximo {1} caracteres")]
        [Display(Name = "Nome Do Cliente")]
        public string TelefoneCliente{ get; set; }

        [Required(ErrorMessage = "Informe o E-mail")]
        [StringLength(100)]
        [DataType(DataType.EmailAddress)]
        public string EmailCliente{ get; set; }

        [Required(ErrorMessage = "O CPF deve Ser Informado")]
        [MaxLength(30, ErrorMessage = "O CPF deve ter no maximo {1} caracteres")]
        [Display(Name = "CPF Do Cliente")]
        public string CPFCliente{ get; set; }



        //Chave estrangeira 1
        public int EnderecoId { get; set; }
        public virtual Endereco Endereco{ get; set; }
   

        
    }
}
