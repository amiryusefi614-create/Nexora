using System;
using System.Collections.Generic;
using System.Text;

namespace Nexora.Domain.Common.Entities;

public abstract class TenantOwnedEntity : AuditableEntity
{
    public Guid OrganizationId { get; private set; }

    protected TenantOwnedEntity()
    {
    }

    protected TenantOwnedEntity(Guid organizationId)
    {
        if (organizationId == Guid.Empty)
            throw new ArgumentException(
                "Organization ID cannot be empty.");

        OrganizationId = organizationId;
    }
}
