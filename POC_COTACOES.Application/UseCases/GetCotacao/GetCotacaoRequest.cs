using MediatR;

namespace POC_COTACOES.Application.UseCases.GetCotacao
{
    public sealed class GetCotacaoRequest : IRequest<GetCotacaoResponse>
    {
        public string Moeda { get; set; }

        public GetCotacaoRequest(string moeda)
        {
            Moeda = moeda;
        }
    }
}
