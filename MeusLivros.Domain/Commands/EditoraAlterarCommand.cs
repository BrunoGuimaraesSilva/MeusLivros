using MeusLivros.Domain.Commands.Interfaces;
using MeusLivros.Domain.Validations;

namespace MeusLivros.Domain.Commands;

public class EditoraAlterarCommand : Notificavel, ICommand
{
    public int Id { get; set; }
    public string Name { get; set; }

    public EditoraAlterarCommand() { }
    public EditoraAlterarCommand(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public void validar()
    {
        if (Id == 0)
            AdicionarNotificacao("Id da editora deve ser informado");

        if (string.IsNullOrEmpty(Name))
            AdicionarNotificacao("Nome e o Id da editora deve ser informado");
    }
}
