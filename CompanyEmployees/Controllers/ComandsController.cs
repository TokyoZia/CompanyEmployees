using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/comands")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class ComandssController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public ComandssController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)

        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet, Authorize(Roles = "Manager")]
        public IActionResult GetComands()
        {
            var comand = _repository.Comand.GetAllComands(trackChanges: false);
            var comandDto = _mapper.Map<IEnumerable<ComandDto>>(comand);
            return Ok(comandDto);
        }
    }
}
