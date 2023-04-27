using System.Data.Entity;

namespace ControleEstoque.Web.Models
{
    public class ContextoBD : DbContext
    {
        public ContextoBD() : base("name=principal")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new GrupoProdutoMap());
            modelBuilder.Configurations.Add(new MarcaProdutoMap());
            modelBuilder.Configurations.Add(new PerfilMap());
            modelBuilder.Configurations.Add(new UsuarioMap());
            modelBuilder.Configurations.Add(new LocalArmazenamentoMap());
            modelBuilder.Configurations.Add(new PaisMap());
            modelBuilder.Configurations.Add(new EstadoMap());
            modelBuilder.Configurations.Add(new CidadeMap());
            modelBuilder.Configurations.Add(new FornecedorMap());
        }

        public DbSet<GrupoProdutoModel> GruposProdutos { get; set; }
        public DbSet<MarcaProdutoModel> MarcasProdutos { get; set; }
        public DbSet<PerfilModel> PerfisUsuarios { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<LocalArmazenamentoModel> LocaisArmazenamentos { get; set; }
        public DbSet<PaisModel> Paises { get; set; }
        public DbSet<EstadoModel> Estados { get; set; }
        public DbSet<CidadeModel> Cidades { get; set; }
        public DbSet<FornecedorModel> Fornecedores { get; set; }
    }
}