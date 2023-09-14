namespace webapi.inlock.codeFirst.manha.Interfaces
{
    public interface IJogo
    {
        List<IJogo> Listar();

        IJogo BuscarPorId(Guid id);

        void Cadastrar(IJogo novoJogo);

        void Atualizar(Guid id, IJogo jogo);

        void Deletar(Guid id);
    }
}
