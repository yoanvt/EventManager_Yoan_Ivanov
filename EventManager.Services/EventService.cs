using EventManager.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using EventManager.Data.Models;

namespace EventManager.Services
{
    public class EventService
    {
        protected readonly EventManagerDbContext context;

        public EventService(EventManagerDbContext context)
        {
            this.context = context;
        }

        public IList<Event> GetAll()
        {
            return context.Events.ToList();
        }

        public Event GetSingle(int? id)
        {
            return context.Events.SingleOrDefault(e => e.Id == id);
        }

        public void Add(Event _event)
        {
            context.Add(_event);
            context.SaveChanges();

        }

        public void Update(Event _event)
        {
            var result = context.Events.SingleOrDefault(e => e.Id == _event.Id);
            if (result != null)
            {
                result.Name = _event.Name;
                result.StartDateTime = _event.StartDateTime;
                result.EndDateTime = _event.EndDateTime;
                result.Location = _event.Location;
                context.SaveChanges();

            }
        }

        public void Remove(Event _event)
        {
            if (_event != null)
            {
                context.Events.Remove(_event);
                context.SaveChanges();
            }

        }
        public bool Any(int id)
        {
            return context.Events.Any(e => e.Id == id);
        }
    }
}