using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using POC_COTACOES.Domain.Interfaces;

namespace POC_COTACOES.Application.UseCases.GetCotacao
{
    public class GetCotacaoHandler : IRequestHandler<GetCotacaoRequest, GetCotacaoResponse>
    {
        private readonly IExternalCotacao _externalCotacao;
        private readonly IMapper _mapper;
        private readonly ILogger<GetCotacaoHandler> _logger;

        public GetCotacaoHandler(IExternalCotacao externalCotacao, IMapper mapper, ILogger<GetCotacaoHandler> logger)
        {
            _externalCotacao = externalCotacao;
            _mapper = mapper;
            _logger = logger;
        }

        public async Task<GetCotacaoResponse> Handle(GetCotacaoRequest request, CancellationToken cancellationToken)
        {
            try
            {
                var resultAPI = await _externalCotacao.GetMoeda(request.Moeda);

                var result = _mapper.Map<GetCotacaoResponse>(resultAPI);

                return result;
            }
            catch (Exception ex)
            {
                _logger.LogCritical($"Erro ex: {ex.Message}");

                return new GetCotacaoResponse();
            }
        }
    }
}
