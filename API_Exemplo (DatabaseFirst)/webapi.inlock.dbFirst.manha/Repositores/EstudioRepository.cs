using Microsoft.EntityFrameworkCore;
using webapi.inlock.dbFirst.manha.Contexts;
using webapi.inlock.dbFirst.manha.Domains;
using webapi.inlock.dbFirst.manha.Interfaces;

namespace webapi.inlock.dbFirst.manha.Repositores
{
    public class EstudioRepository : IEstudioRepository
    {
        //Instanciamos para ter acesso ao banco de dados
        InLockContext ctx = new InLockContext();

        public void Atualizar(Guid id, Estudio estudio)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(id);

            if (estudioBuscado != null)
            {
                //Caso o estudioBuscado não seja nulo, o nome do estudio receberá um novo valor
                estudioBuscado.Nome = estudio.Nome;
            }

            ctx.Estudios.Update(estudioBuscado);

            ctx.SaveChanges();  
        }

        public Estudio BuscarPorId(Guid id)
        {
            return ctx.Estudios.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudio estudio)
        {

            ctx.Estudios.Add(estudio);

            ctx.SaveChanges();
        }

        public void Deletar(Guid id)
        {
            Estudio estudioBuscado = ctx.Estudios.Find(id);

            ctx.Estudios.Remove(estudioBuscado);    

            ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudios.ToList();
        }

        public List<Estudio> ListarComJogos()
        {
            return ctx.Estudios.Include(e => e.Jogos).ToList();
        }
    }
}
