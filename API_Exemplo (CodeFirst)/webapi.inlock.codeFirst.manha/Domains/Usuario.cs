using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    [Table("Usuario")]
    [Index(nameof(Email), IsUnique=true)] //Cria um índice único para email 
    public class Usuario
    {
        [Key]
        public Guid IdUsuario { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Email é obrigatório")]
        public string Email { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Senha obrigatória")]
        [StringLength(maximumLength: 20, MinimumLength = 6, ErrorMessage = "Senha deve conter de 6 a 20 caracteres")]
        public string Senha { get; set; }

        //Referência da chave estrangeira (Tabela de TiposUsuario)

        [Required(ErrorMessage = "Tipo de usuário obrigatório")]
        public Guid IdTiposUsuario { get; set; }


        [ForeignKey("IdTiposUsuario")]
        public TiposUsuario? TiposUsuario { get; set; }
    }
}
