﻿using AutoMapper;
using Contracts;
using Entities.DataTransferObjects;
using Entities.Models;
using LoggerService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CompanyEmployees.Controllers
{
    [Route("api/players")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class PlayersController : ControllerBase
    {
        private readonly IRepositoryManager _repository;
        private readonly ILoggerManager _logger;
        private readonly IMapper _mapper;
        public PlayersController(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)

        {
            _repository = repository;
            _logger = logger;
            _mapper = mapper;
        }
        [HttpGet, Authorize(Roles = "Manager")]
        public IActionResult GetPlayers()
        {
            var players = _repository.Player.GetAllPlayers(trackChanges: false);
            var playerDto = _mapper.Map<IEnumerable<ComandDto>>(players);
            return Ok(playerDto);
        }
    }
}
