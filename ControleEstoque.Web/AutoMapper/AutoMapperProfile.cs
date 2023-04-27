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
                cfg.CreateMap<LocalArmazenamentoViewModel, LocalArmazenamentoModel>().ReverseMap();
                cfg.CreateMap<PaisViewModel, PaisModel>().ReverseMap();
                cfg.CreateMap<EstadoViewModel, EstadoModel>().ReverseMap();
                cfg.CreateMap<CidadeViewModel, CidadeModel>().ReverseMap();
                cfg.CreateMap<FornecedorViewModel, FornecedorModel>().ReverseMap();
            }).CreateMapper();

            return config;
        }
    }
}