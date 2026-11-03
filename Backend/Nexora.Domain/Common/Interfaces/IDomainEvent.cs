using System;
using System.Collections.Generic;
using System.Text;

namespace Nexora.Domain.Common.Interfaces;

public interface IDomainEvent
{
    Guid EventId { get; }

    DateTimeOffset OccurredOnUtc { get; }
}
