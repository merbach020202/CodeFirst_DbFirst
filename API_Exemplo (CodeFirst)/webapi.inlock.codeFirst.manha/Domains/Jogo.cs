using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace webapi.inlock.codeFirst.manha.Domains
{
    /// <summary>
    /// Classe que representa a entidade jogo
    /// </summary>
    [Table("Jogo")]
    public class Jogo
    {
        [Key]
        public Guid IdJogo { get; set; } = Guid.NewGuid();

        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Nome do jogo é obrigatório")]
        public string Nome { get; set; }


        [Column(TypeName = "TEXT")]
        [Required(ErrorMessage = "Descrição é obrigatória")]
        public string Descricao { get; set; }


        [Column(TypeName = "VARCHAR(100)")]
        [Required(ErrorMessage = "Data do lançamento é obrigatório")]
        public string DataLancamento { get; set; }


        [Column(TypeName = "DECIMAL(4,2)")]
        [Required(ErrorMessage = "Valor é obrigatório")]
        public int Preco { get; set; }


        //Referência da chave estrangeira (Tabela de estúdio)

        [Required(ErrorMessage = "Informe o estúdio que produziu o jogo")]
        public Guid IdEstudio { get; set; }
       

        [ForeignKey("IdEstudio")]
        public Estudio? Estudio { get; set; }

    }
}
