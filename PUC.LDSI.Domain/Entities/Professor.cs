using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PUC.LDSI.Domain.Entities
{
    public class Professor
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLength(100)]
        public string Nome { get; set; }
        [StringLength(50)]
        public string Login { get; set; }
        [StringLength(50)]
        public string Senha { get; set; }
        public List<Avaliacao> Avaliacoes { get; set; }
    }
}
