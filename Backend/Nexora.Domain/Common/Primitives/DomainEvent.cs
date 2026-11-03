using System;
using System.Collections.Generic;
using System.Text;

using Nexora.Domain.Common.Interfaces;

namespace Nexora.Domain.Common.Primitives;

public abstract record DomainEvent : IDomainEvent
{
    public Guid EventId { get; } = Guid.NewGuid();

    public DateTimeOffset OccurredOnUtc { get; } =
        DateTimeOffset.UtcNow;
}
