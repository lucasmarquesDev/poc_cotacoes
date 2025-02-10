using MediatR;
using Microsoft.Extensions.Logging;
using POC_COTACOES.Application.UseCases.GetCotacao;
using POC_COTACOES.Domain.Interfaces;

namespace POC_COTACOES.Application.Service
{
    public class CotacaoService : ICotacaoService
    {
        private readonly ILogger<CotacaoService> _logger;
        IMediator _mediator;

        public CotacaoService(IMediator mediator, ILogger<CotacaoService> logger)
        {
            _mediator = mediator;
            _logger = logger;
        }

        public async Task<GetCotacaoResponse> BuscarCotacao(string moeda)
        {
            _logger.LogInformation("Chamando usecase para buscar cotacao");

            var result = await _mediator.Send(new GetCotacaoRequest(moeda));

            return result;
        }
    }
}
