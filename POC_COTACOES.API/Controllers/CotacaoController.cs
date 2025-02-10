using Microsoft.AspNetCore.Mvc;
using POC_COTACOES.Application;

namespace POC_COTACOES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {
        private readonly ICotacaoService _cotacaoService;

        public CotacaoController(ICotacaoService cotacaoService)
        {
            _cotacaoService = cotacaoService;
        }

        [HttpGet("buscar-cotacao")]
        public async Task<IActionResult> GetCotacao([FromQuery] string moeda)
        {
            var cotacao = await _cotacaoService.BuscarCotacao(moeda);

            if (cotacao == null) return NotFound("Cotação não encontrada");

            return Ok(cotacao);
        }
    }
}
