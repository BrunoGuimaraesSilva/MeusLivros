using MeusLivros.Domain.Commands.Interfaces;
using MeusLivros.Domain.Validations;

namespace MeusLivros.Domain.Commands;

public class LivroInserirCommand : Notificavel, ICommand
{
    public string Name { get; set; }
    public int IdEditora { get; set; }

    public LivroInserirCommand() { }
    public LivroInserirCommand(string name, int idEditora)
    {
        Name = name;
        IdEditora = idEditora;
    }

    public void Validar()
    {
        if (IdEditora <= 0)
            AdicionarNotificacao("A editora deve ser informada");

        if (string.IsNullOrEmpty(Name))
            AdicionarNotificacao("O nome deve ser informada");

    }
}
