using Microsoft.EntityFrameworkCore;
using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PUC.LDSI.DataBase.Context
{
    public class AppDBContext : DbContext
    {
        public DbSet<Aluno> Alunos { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<OpcaoAvaliacao> OpcoesAvaliacao { get; set; }
        public DbSet<OpcaoProva> OpcoesProva { get; set; }
        public DbSet<Professor> Professores { get; set; }
        public DbSet<Prova> Provas { get; set; }
        public DbSet<Publicacao> Publicacoes { get; set; }
        public DbSet<Questao> Questoes { get; set; }
        public DbSet<QuestaoProva> QuestoesProva { get; set; }
        public DbSet<Turma> Turmas { get; set; }

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) // construtor da classe
        { }
        
        protected override void OnModelCreating(ModelBuilder modelbuilder)//evento OnModelCreating reeescrevendo na classe filha
        {
            foreach (var relationship in modelbuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            base.OnModelCreating(modelbuilder);
        }
    }

}
