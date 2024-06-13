using System.ComponentModel.DataAnnotations;
using Base.Contracts.Domain;

namespace Base.Domain;

public abstract class DomainEntityMetaId : DomainEntityId<Guid>, IDomainEntityId, IDomainEntityMeta
{
    
    public string? CreatedBy { get; set; }


    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.Now;
    public string? UpdatedBy { get; set; }
    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.Now;
    public string? DeletedBy { get; set; }
    public DateTimeOffset? DeletedAt { get; set; } = null;
}

public abstract class DomainEntityMetaId<TKey> : DomainEntityId<TKey>,
    IDomainEntityMeta where TKey : IEquatable<TKey>
{
    [MaxLength(64)]
    public string? CreatedBy { get; set; }

    public DateTimeOffset CreatedAt { get; set; } = DateTimeOffset.UtcNow;

    [MaxLength(64)] 
    public string? UpdatedBy { get; set; }

    public DateTimeOffset UpdatedAt { get; set; } = DateTimeOffset.UtcNow;



    [MaxLength(64)] public string? DeletedBy { get; set; }

    public DateTimeOffset? DeletedAt { get; set; } = null;
   
}