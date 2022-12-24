using Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiVersion("2.0", Deprecated = true)]
    [Route("api/{v:apiversion}/companies")]
    [ApiController]
    public class CompaniesV2Controller : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        public CompaniesV2Controller(IRepositoryManager repository)
        {
            _repository = repository;
        }
        [HttpGet]
        public  IActionResult GetCompanies()
        {
            var companies = _repository.Company.GetAllCompanies(trackChanges:
            false);
            return Ok(companies);
        }
    }
}
