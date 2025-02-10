using POC_COTACOES.Application.UseCases.GetCotacao;

namespace POC_COTACOES.Application
{
    public interface ICotacaoService
    {
        Task<GetCotacaoResponse> BuscarCotacao(string moeda);
    }
}
