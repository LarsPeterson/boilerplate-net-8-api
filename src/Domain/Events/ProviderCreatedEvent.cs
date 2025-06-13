using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Events
{
    public class ProviderCreatedEvent(string name) : IDomainEvent
    {
        public string Name { get; set; } = name;
        public DateTime OccurredOn { get; } = DateTime.Now;
    }
}
