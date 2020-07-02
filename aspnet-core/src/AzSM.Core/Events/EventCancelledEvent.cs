using Abp.Events.Bus.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AzSM.Events
{
    public class EventCancelledEvent : EntityEventData<Event>
    {
        public EventCancelledEvent(Event entity)
            : base(entity)
        {
        }
    }
}
