using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class OpcaoProva
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("OpcaoAvaliacao")]
        public int OpcaoAvaliacaoId { get; set; }
        [ForeignKey("QuestaoProva")]
        public int QuestaoProvaId { get; set; }
        public bool Resposta { get; set; }
        public QuestaoProva QuestaoProva { get; set; }
        public OpcaoAvaliacao OpcaoAvaliacao { get; set; }
    }
}
