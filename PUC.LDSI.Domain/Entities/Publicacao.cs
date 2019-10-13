using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Publicacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Avaliacao")]
        public int AvaliacaoId { get; set; }
        [ForeignKey("Turma")]
        public int TurmaId { get; set; }
        public DateTime DataPublicacao { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int ValorProva { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Turma Turma { get; set; }

    }
}
