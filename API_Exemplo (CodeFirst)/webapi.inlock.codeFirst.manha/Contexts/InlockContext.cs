using Microsoft.EntityFrameworkCore;
using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Contexts
{
    public class InlockContext : DbContext
    {
        //Definir as entidades do banco de dados
        public DbSet<Estudio> Estudio { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<TiposUsuario> tiposUsuario { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        /// <summary>
        ///  Define as opções de contrução do banco(String Conexão)
        /// </summary>
        /// <param name="Objeto com as configurações definidas"></param>
       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=NOTE05-S15; DataBase=inlock_games_CodeFirst_manha_Eduardo; User Id=sa; Password=Senai@134; TrustServerCertificate=True;");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
