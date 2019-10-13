using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Aluno
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("Turma")]
        public int TurmaId { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(50)]
        public  string Matricula { get; set; }
        [StringLength(50)]
        public string Senha { get; set; }
        public List<Prova> Provas { get; set; }
        public Turma Turma { get; set; }

    }
}
