using MeusLivros.Domain.Commands.Interfaces;
using MeusLivros.Domain.Validations;

namespace MeusLivros.Domain.Commands
{
    internal class LivroAlterarCommand : Notificavel, ICommand
    {
        public int Id { get; private set; }
        public string Name { get; set; }
        public int IdEditora { get; set; }

        public LivroAlterarCommand() { }
        public LivroAlterarCommand(int id, string name, int idEditora)
        {
            Id = id;
            Name = name;
            IdEditora = idEditora;
        }

        public void Validar()
        {
            if (Id <= 0)
                AdicionarNotificacao("O livro deve ser informado");

            if (IdEditora <= 0)
                AdicionarNotificacao("A editora deve ser informada");

            if (string.IsNullOrEmpty(Name))
                AdicionarNotificacao("O nome deve ser informado");
        }

    }
}
