using Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public sealed class Webinar : Entity
    {
        public Webinar(Guid id, string name, DateTime scheduledOn)
            :base(id)
        {
            Name = name;
            ScheduledOn = scheduledOn;

        }
        public string Name { get; private set; }
        public DateTime ScheduledOn { get; private set; }
    }
}
