using POC_COTACOES.Domain.DTO;

namespace POC_COTACOES.Domain.Interfaces
{
    public interface IExternalCotacao
    {
        Task<MoedaInfo> GetMoeda(string moeda);
    }
}
