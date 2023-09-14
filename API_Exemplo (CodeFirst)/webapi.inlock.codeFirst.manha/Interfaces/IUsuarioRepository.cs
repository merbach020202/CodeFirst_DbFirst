using webapi.inlock.codeFirst.manha.Domains;

namespace webapi.inlock.codeFirst.manha.Interfaces
{
    public interface IUsuarioRepository
    {
        Usuario BuscarUsuario(String email, string Senha);

        void Cadastrar(Usuario usuario);
    }
}
