using Application.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events;
using MediatR;

namespace Application.Events.Handlers;

public class ProviderCreatedHandler(IEmailService emailService) : INotificationHandler<DomainEventNotification<ProviderCreatedEvent>>
{
    public async Task Handle(DomainEventNotification<ProviderCreatedEvent> notification, CancellationToken ct)
    {
        await emailService.SendWelcomeEmailAsync(notification.DomainEvent.Name);
    }
}