using MeusLivros.Domain.Commands.Interfaces;
using MeusLivros.Domain.Validations;

namespace MeusLivros.Domain.Commands;

public class EditoraExcluirCommand : Notificavel, ICommand
{
    public int Id { get; set; }

    public EditoraExcluirCommand() { }
    public EditoraExcluirCommand(int id)
    {
        Id = id;
    }

    public void validar()
    {
        if (Id == 0)
            AdicionarNotificacao("Id da editora deve ser informado");
    }
}
