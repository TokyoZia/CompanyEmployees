using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    using Contracts;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    namespace CompanyEmployees.Controllers
    {
        [ApiVersion("2.0", Deprecated = true)]
        [Route("api/{v:apiversion}/comands")]
        [ApiController]
        public class ComandsV2Controller : ControllerBase
        {
            private readonly IRepositoryManager _repository;
            public ComandsV2Controller(IRepositoryManager repository)
            {
                _repository = repository;
            }
            [HttpGet]
            public IActionResult GetCompanies()
            {
                var companies = _repository.Comand.GetAllComands(trackChanges:
                false);
                return Ok(companies);
            }
        }
    }

}
