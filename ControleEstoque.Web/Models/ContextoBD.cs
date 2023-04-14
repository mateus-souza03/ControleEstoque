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
        }

        public DbSet<GrupoProdutoModel> GruposProdutos { get; set; }
        public DbSet<MarcaProdutoModel> MarcasProdutos { get; set; }
        public DbSet<PerfilModel> PerfisUsuarios { get; set; }
        public DbSet<UsuarioModel> Usuarios { get; set; }
    }
}