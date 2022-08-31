using MeusLivros.Domain.Commands;
using MeusLivros.Domain.Commands.Interfaces;
using MeusLivros.Domain.Entities;
using MeusLivros.Domain.Handlers.Interfaces;
using MeusLivros.Domain.Repositories;

namespace MeusLivros.Domain.Handlers;


public class EditoraHandler :
    IHandler<EditoraInserirCommand>,
    IHandler<EditoraAlterarCommand>,
    IHandler<EditoraExcluirCommand>
{
    private readonly IEditoraRepository _repository;
    public EditoraHandler(IEditoraRepository repository)
    {
        _repository = repository;
    }

    #region Inserir
    public ICommandResult Handle(EditoraInserirCommand command)
    {
        command.validar();
        if (command.isInvalid)
        {
            return new CommandResult(false, "Erro ao inserir", command.Notificacoes);
        }

        var editora = new Editora(command.Name);
        _repository.Inserir(editora);
        return new CommandResult(true, "Editora inserida com sucesso", editora);
    }

    #endregion

    #region Alterar


    public ICommandResult Handle(EditoraAlterarCommand command)
    {
        command.validar();
        if (command.isInvalid)
        {
            return new CommandResult(false, "Erro ao inserir", command.Notificacoes);
        }

        var editora = _repository.BuscarPorId(command.Id);

        if (editora == null)
        {
            return new CommandResult(false, "Editora não encontrada", command);
        }

        _repository.Alterar(editora);
        return new CommandResult(true, "Editora alterada com sucesso", editora);
    }

    #endregion

    #region Excluir
    public ICommandResult Handle(EditoraExcluirCommand command)
    {
        command.validar();
        if (command.isInvalid)
        {
            return new CommandResult(false, "Erro ao inserir", command.Notificacoes);
        }
        var editora = _repository.BuscarPorId(command.Id);

        if (editora == null)
            return new CommandResult(false, "Editora não encontrada", command);

        _repository.Excluir(editora);
        return new CommandResult(true, "Editora alterada com sucesso", editora);
    }

    #endregion
}
