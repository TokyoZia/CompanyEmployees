using Contracts;
using Entities;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ComandRepository : RepositoryBase<Comand>, IComandRepository
    {
        public ComandRepository(RepositoryContext repositoryContext): base(repositoryContext)
        {
        }

        public void AnyMethodFromCompanyRepository()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Comand> GetAllComands(bool trackChanges) =>
     FindAll(trackChanges)
         .OrderBy(c => c.ComandName)
         .ToList();
    }
}
