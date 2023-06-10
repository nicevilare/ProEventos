using ProEventos.Domain;
using ProEventos.API.Dtos;
using AutoMapper;
using ProEventos.Application.Dtos;

namespace ProEventos.API.Helpers
{
    public class ProEventosProfile : Profile
    {
        public ProEventosProfile() {
            CreateMap<Evento, EventoDto>().ReverseMap();
            CreateMap<Lote, LoteDto>().ReverseMap();
            CreateMap<RedeSocial, RedeSocialDto>().ReverseMap();
            CreateMap<Palestrante, PalestranteDto>().ReverseMap();
        }        
    }
}