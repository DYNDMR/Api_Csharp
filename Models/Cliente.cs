using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_agencia.Models
{
    [Table("cliente")]
    public class Cliente
    {
        [Key]
        public long Id { get; set; }

        [Required(ErrorMessage = "Digite seu nome")]
        [StringLength(100)]
        public String Nome { get; set; }

        [Required(ErrorMessage = "Digite seu CPF")]
        [StringLength(20)]
        public String Cpf { get; set; }

        [Required(ErrorMessage = "Digite seu E-mail")]
        [StringLength(100)]
        public String Email { get; set; }

        [Required(ErrorMessage = "Digite sua senha")]
        [StringLength(20)]
        public String Senha { get; set; }

    }
}
