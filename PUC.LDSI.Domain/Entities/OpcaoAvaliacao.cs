using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoAvaliacao
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Questao")]
        public int QuestaoId { get; set; }
        [StringLength(1000)]
        public string Descricao { get; set; }
        public bool Verdadeira { get; set; }
        public Questao Questao { get; set; }
        public List<OpcaoProva> OpcoesProva { get; set; }

    }
}
