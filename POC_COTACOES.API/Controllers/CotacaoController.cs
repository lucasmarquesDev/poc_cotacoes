using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace POC_COTACOES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {
        [HttpGet("buscar-cotacao")]
        public async Task<IActionResult> GetCotacao([FromQuery] string moeda)
        {
            return Ok();
        }
    }
}
