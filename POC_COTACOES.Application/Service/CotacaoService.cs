using MediatR;
using POC_COTACOES.Application.UseCases.GetCotacao;
using POC_COTACOES.Domain.Interfaces;

namespace POC_COTACOES.Application.Service
{
    public class CotacaoService : ICotacaoService
    {
        IMediator _mediator;

        public CotacaoService(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<GetCotacaoResponse> BuscarCotacao(string moeda)
        {
            var result = await _mediator.Send(new GetCotacaoRequest(moeda));

            return result;
        }
    }
}
