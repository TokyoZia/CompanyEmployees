using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using LoggerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/{v:apiversion}/companies")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CompaniesController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public CompaniesController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet, Authorize(Roles = "Manager")]
        [HttpHead]
        public IActionResult GetCompanies()
        {
                var companies = _repository.Company.GetAllCompanies(trackChanges: false);
                var companiesDto = _mapper.Map<IEnumerable<CompanyDto>>(companies);
                return Ok(companiesDto);
        }

        [HttpOptions]
        public IActionResult GetCompaniesOptions()
        {
            Response.Headers.Add("Allow", "GET, OPTIONS, POST");
            return Ok();
        }
    }
}
