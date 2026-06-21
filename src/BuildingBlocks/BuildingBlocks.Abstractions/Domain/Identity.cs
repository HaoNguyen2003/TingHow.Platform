using System;
using System.Collections.Generic;
using System.Text;
using BuildingBlocks.Abstractions.Domain;

namespace BuildingBlocks.Abstractions.Domain
{
    public abstract record Identity<TId>
    {
        public TId Value { get; set; } = default!;

        public static implicit operator TId(Identity<TId> identity) => identity.Value;

        public override string ToString()
        {
            return IdAsString();
        }

        public string IdAsString()
        {
            return $"{GetType().Name}";
        }
    }
}

public abstract record Identity : Identity<long>;