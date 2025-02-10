using AutoMapper;
using MediatR;
using POC_COTACOES.Domain.Interfaces;

namespace POC_COTACOES.Application.UseCases.GetCotacao
{
    public class GetCotacaoHandler : IRequestHandler<GetCotacaoRequest, GetCotacaoResponse>
    {
        private readonly IExternalCotacao _externalCotacao;
        private readonly IMapper _mapper;

        public GetCotacaoHandler(IExternalCotacao externalCotacao, IMapper mapper)
        {
            _externalCotacao = externalCotacao;
            _mapper = mapper;
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

                throw;
            }
        }
    }
}
