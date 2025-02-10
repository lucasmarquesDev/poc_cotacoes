using Microsoft.AspNetCore.Mvc;
using POC_COTACOES.Application;

namespace POC_COTACOES.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CotacaoController : ControllerBase
    {
        private readonly ICotacaoService _cotacaoService;
        private readonly ILogger<CotacaoController> _logger;

        public CotacaoController(ICotacaoService cotacaoService, ILogger<CotacaoController> logger)
        {
            _cotacaoService = cotacaoService;
            _logger = logger;
        }

        [HttpGet("buscar-cotacao")]
        public async Task<IActionResult> GetCotacao([FromQuery] string moeda)
        {
            _logger.LogInformation($"Buscando cotação para a moeda {moeda}");

            var cotacao = await _cotacaoService.BuscarCotacao(moeda);

            if (cotacao == null) return NotFound("Cotação não encontrada");

            return Ok(cotacao);
        }
    }
}
