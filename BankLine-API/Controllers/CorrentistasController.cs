using BankLine_API.Models;
using BankLine_API.Repository.Correntistas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BankLine_API.Controllers
{
    [Route("bankline-api/correntistas")]
    [ApiController]
    public class CorrentistasController : ControllerBase
    {
        private readonly ICorrentistaService _correntistaService;

        public CorrentistasController(ICorrentistaService correntistaService)
        {
            _correntistaService = correntistaService;
        }

        // GET: bankline-api/correntistas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Correntista>>> GetCorrentistas()
        {
            var correntistas = await _correntistaService.GetAllCorrentistasAsync();
            return Ok(correntistas);
        }
    }
}