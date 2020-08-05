﻿using System;

namespace Couponel.Entities
{
    public abstract class Entity
    {
        protected Entity()
        {
            Id = Guid.NewGuid();
        }
        protected Entity(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}
