using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Events;

namespace Domain.Entities
{
    public class Provider(string name, string fyb, string fye)
    {
        public IReadOnlyCollection<IDomainEvent> DomainEvents { get; } = [new ProviderCreatedEvent(name)];
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string FYB { get; set; } = fyb;
        public string FYE { get; set; } = fye;
    }
}
