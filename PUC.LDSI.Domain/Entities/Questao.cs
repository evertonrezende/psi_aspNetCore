using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Questao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Avaliacao")]
        public int AvaliacaoId { get; set; }
        public int Tipo { get; set; }
        [StringLength(4000)]
        public string Enunciado { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public List<OpcaoAvaliacao> OpcoesAvaliacao { get; set; }
        public List<QuestaoProva> QuestoesProva { get; set; }

    }
}
