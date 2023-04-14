using AutoMapper;
using ControleEstoque.Web.Models;

namespace ControleEstoque.Web
{
    public static class AutoMapperProfile
    {
        public static IMapper CreateConfig()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GrupoProdutoViewModel, GrupoProdutoModel>().ReverseMap();
                cfg.CreateMap<MarcaProdutoViewModel, MarcaProdutoModel>().ReverseMap();
                cfg.CreateMap<PerfilViewModel, PerfilModel>().ReverseMap();
                cfg.CreateMap<MarcaProdutoViewModel, MarcaProdutoModel>().ReverseMap();
                cfg.CreateMap<UsuarioViewModel, UsuarioModel>().ReverseMap();
            }).CreateMapper();

            return config;
        }
    }
}