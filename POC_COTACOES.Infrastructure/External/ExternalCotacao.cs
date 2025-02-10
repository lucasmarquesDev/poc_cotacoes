using POC_COTACOES.Domain.DTO;
using POC_COTACOES.Domain.Interfaces;
using Newtonsoft.Json;

namespace POC_COTACOES.Infrastructure.External
{
    public class ExternalCotacao : IExternalCotacao
    {
        private readonly HttpClient _httpClient;
        private string _url = "https://economia.awesomeapi.com.br/json/last/";

        public ExternalCotacao()
        {
            _httpClient = new HttpClient();
        }

        public async Task<MoedaInfo> GetMoeda(string moeda)
        {
            var url = _url + moeda.ToLower();

            var response = await _httpClient.GetAsync(url);
            response.EnsureSuccessStatusCode();

            var responseBody = await response.Content.ReadAsStringAsync();

            var result = JsonConvert.DeserializeObject<Dictionary<string, MoedaInfo>>(responseBody);

            return result.Values.FirstOrDefault();
        }
    }
}
