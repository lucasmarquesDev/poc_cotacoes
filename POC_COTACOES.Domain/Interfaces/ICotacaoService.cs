namespace POC_COTACOES.Domain.Interfaces
{
    public interface ICotacaoService
    {
        public Task<string> BuscarCotacao(string moeda);
    }
}
