// Copyright (c) MASA Stack All rights reserved.
// Licensed under the MIT License. See LICENSE.txt in the project root for license information.

namespace Masa.Contrib.Dispatcher.IntegrationEvents.EventLogs.EF.Tests.Events;

public abstract record IntegrationEvent : IIntegrationEvent
{
    public Guid Id { get; init; }

    public DateTime CreationTime { get; init; }

    [JsonIgnore]
    public IUnitOfWork? UnitOfWork { get; set; }

    public abstract string Topic { get; set; }

    public IntegrationEvent() : this(Guid.NewGuid(), DateTime.UtcNow) { }

    public IntegrationEvent(Guid Id, DateTime CreationTime)
    {
        this.Id = Id;
        this.CreationTime = CreationTime;
    }
}
