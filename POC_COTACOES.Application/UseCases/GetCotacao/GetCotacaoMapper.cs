using AutoMapper;
using POC_COTACOES.Domain.DTO;

namespace POC_COTACOES.Application.UseCases.GetCotacao
{
    public sealed class GetCotacaoMapper : Profile
    {
        public GetCotacaoMapper()
        {
            CreateMap<MoedaInfo, GetCotacaoResponse>();
        }
    }
}
