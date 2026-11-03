using System;
using System.Collections.Generic;
using System.Text;

using Nexora.Domain.Common.Primitives;

namespace Nexora.Domain.Common.Entities;

public abstract class AuditableEntity : Entity
{
    public DateTimeOffset CreatedAtUtc { get; private set; }

    public DateTimeOffset? UpdatedAtUtc { get; private set; }

    protected AuditableEntity()
    {
        CreatedAtUtc = DateTimeOffset.UtcNow;
    }

    protected void MarkAsUpdated()
    {
        UpdatedAtUtc = DateTimeOffset.UtcNow;
    }
}