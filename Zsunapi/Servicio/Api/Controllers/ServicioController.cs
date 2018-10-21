using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Application.Dto;
using Application.Service;
using System.Net;

namespace Zsunapi.Servicio.Api.Controllers
{
    public class ServicioController
    {
    }
    using Microsoft.AspNetCore.Mvc;

    [Produces("application/json")]
    [Route("api/Servicio")]
    public class ServicioController : Controller
    {
        private readonly IProductApplicationService _productApplicationService;
        private readonly IAmqpApplicationService _amqpApplicationService;
        public ServicioController(IServicioApplicationService productApplicationService,
            IAmqpApplicationService amqpApplicationService)
        {
            _servicioApplicationService = productApplicationService;
            _amqpApplicationService = amqpApplicationService;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ServicioOutputDto), (int)HttpStatusCode.OK)]
        public IActionResult Get(int id)
        {
            return Ok(_productApplicationService.Get(id));
        }

        [HttpGet]
        [ProducesResponseType(typeof(List<ServicioOutputDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetAll()
        {
            return Ok(_productApplicationService.GetAll());
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), (int)HttpStatusCode.OK)]
        public IActionResult Create([FromBody] ServicioCreateDto model)
        {
            long servicioId = _servicioApplicationService.Create(model);
            _amqpApplicationService.PublishMessage(servicioId);
            return Ok("Servicio Creado!");
        }

        [HttpGet("expensives")]
        [ProducesResponseType(typeof(List<ServicioOutputDto>), (int)HttpStatusCode.OK)]
        public IActionResult GetExpensives()
        {
            return Ok(_productApplicationService.GetExpensives());
        }
    }
}
