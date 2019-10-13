using PUC.LDSI.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace PUC.LDSI.Domain.Repository
{
    public interface IProfessorRepository
    {
        Task<int> IncluirNovoProfessorAsync(Professor professor);

        Professor ObterProLogin(string login);
    }
}
