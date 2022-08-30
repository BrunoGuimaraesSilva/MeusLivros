using MeusLivros.Domain.Commands.Interfaces;
using MeusLivros.Domain.Validations;

namespace MeusLivros.Domain.Commands;

public class EditoraInserirCommand : Notificavel, ICommand
{
    public string Name { get; set; }

    public EditoraInserirCommand() { }
    public EditoraInserirCommand(string name)
    {
        Name = name;
    }

    public void validar()
    {
        if (string.IsNullOrEmpty(Name))
        {
            AdicionarNotificacao("Nome da editora deve ser informado");
        }
    }
}
