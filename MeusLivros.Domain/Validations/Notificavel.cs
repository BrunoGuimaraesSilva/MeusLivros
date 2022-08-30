namespace MeusLivros.Domain.Validations;

public class Notificavel
{
    private readonly List<string> _notificavel;

    public Notificavel()
    {
        _notificavel = new List<string>();

    }

    public void AdicionarNotificacao(string mensagem)
    {
        _notificavel.Add(mensagem);
    }
    public IReadOnlyCollection<string> Notificacoes => _notificavel;

    public bool isInvalid => _notificavel.Any();
    public bool isValid => !isInvalid;
}
