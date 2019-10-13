using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Prova
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Avaliacao")]
        public int AvaliacaoId { get; set; }
        [ForeignKey("Aluno")]
        public  int AlunoId { get; set; }
        public DateTime DataProva { get; set; }
        [Column(TypeName = "decimal(10,4)")]
        public decimal NotaObtida { get; set; }
        public Avaliacao Avaliacao { get; set; }
        public Aluno Aluno { get; set; }
        public List<QuestaoProva> QuestoesProva { get; set; }
    }
}
