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
    public class PlayerRepository : RepositoryBase<Player>, IPlayerRepository
    {
        public PlayerRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {
        }

        public IEnumerable<Company> GetAllPlayers(bool trackChanges) =>
      FindAll(trackChanges)
          .OrderBy(c => c.Name)
          .ToList();

        public void AnyMethodFromCompanyRepository()
        {
            throw new NotImplementedException();
        }
    }
}
