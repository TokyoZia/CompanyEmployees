using Contracts;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RepositoryManager : IRepositoryManager
    {
        private RepositoryContext _repositoryContext;
        private ICompanyRepository _companyRepository;
        private IEmployeeRepository _employeeRepository;
        private IComandRepository _comandRepository;
        private IPlayerRepository _playerRepository;
        public RepositoryManager(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }
        public ICompanyRepository Company
        {
            get
            {
                if (_companyRepository == null)
                    _companyRepository = new CompanyRepository(_repositoryContext);
                return _companyRepository;
            }
        }
        public IEmployeeRepository Employee
        {
            get
            {
                if (_employeeRepository == null)
                    _employeeRepository = new EmployeeRepository(_repositoryContext);
                return _employeeRepository;
            }
        }

        public IPlayerRepository Player
        {
            get
            {
                if (_playerRepository == null)
                    _playerRepository = new PlayerRepository(_repositoryContext);
                return _playerRepository;
            }
        }

        public IComandRepository Comand
        {
            get
            {
                if (_comandRepository == null)
                    _comandRepository = new ComandRepository(_repositoryContext);
                return _comandRepository;
            }
        }
        public void Save() => _repositoryContext.SaveChanges();
    }
}
