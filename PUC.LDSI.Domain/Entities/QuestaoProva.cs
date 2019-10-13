using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class QuestaoProva
    {
        [Key]  //informa que o campo ID é chave primária
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //auto incremental
        public int Id { get; set; }
        [ForeignKey("Prova")]
        public int ProvaId { get; set; }
        [ForeignKey("Questao")]
        public int QuestaoId { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal Nota { get; set; }
        public Questao Questao { get; set; }
        public List<OpcaoProva> OpcoesProva { get; set; }
        public Prova Prova { get; set; }
    }
}
