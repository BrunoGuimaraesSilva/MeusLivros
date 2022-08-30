using System.Diagnostics.CodeAnalysis;

namespace MeusLivros.Domain.Entities;

public abstract class Entity : IEquatable<Entity>
{
    public int Id { get; set; }

    public bool Equals(Entity? other)
    {
        return Id == other?.Id;
    }

    public int GetHashCode([DisallowNull] Entity obj)
    {
        throw new NotImplementedException();
    }
}
