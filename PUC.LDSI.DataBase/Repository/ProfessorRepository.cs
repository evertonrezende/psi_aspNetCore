using PUC.LDSI.DataBase.Context;
using PUC.LDSI.Domain.Entities;
using PUC.LDSI.Domain.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.DataBase.Repository
{
    public class ProfessorRepository : IProfessorRepository
    {
        private readonly AppDBContext _context;

        public ProfessorRepository(AppDBContext context)
        {
            _context = context;
        }
        public async Task<int> IncluirNovoProfessorAsync(Professor professor)
        {
            _context.Add(professor);

            return await _context.SaveChangesAsync();
        }

        public Professor ObterProLogin(string login)
        {
            return _context.Professores
                .Where(x => x.Login == login).FirstOrDefault();
        }
    }
}
