using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PrimeiraAPI.Services;
using PrimeiraAPI.Entities;

namespace PrimeiraAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarroController : ControllerBase
    {
        private readonly ILogger<CarroController> _logger;
        private readonly ICarroService _carro;
        
        public CarroController(ILogger<CarroController> logger, ICarroService carro){
            _logger = logger;
            _carro = carro;    
        }

        [HttpGet]
        public IActionResult TodosCarros(){
            return Ok(_carro.RetornarListCarro());
        }

        [HttpGet("{id}")]
        public IActionResult carro(int id){
            return Ok(_carro.RetornarCarroPorId(id));
        }

        [HttpPost]
        public IActionResult carroAdd([FromBody] Carro novaCarro)
        {
            return Ok(_carro.AdicionarCarro(novaCarro));
        }

        [HttpPut]
        public IActionResult carroUpdate([FromBody] Carro novoCarro){
            return Ok(_carro.AtualizarCarro(novoCarro));
        }

        [HttpDelete("{id}")]
        public IActionResult carroDelete(int id){
            return Ok(_carro.DeletarCarro(id));
        }
    }
}