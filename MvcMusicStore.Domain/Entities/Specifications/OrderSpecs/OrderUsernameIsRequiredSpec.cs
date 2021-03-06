﻿using System;
using MvcMusicStore.Domain.Interfaces.Validation;

namespace MvcMusicStore.Domain.Entities.Specifications.OrderSpecs
{
    public class OrderUsernameIsRequiredSpec : ISpecification<Order>
    {
        public bool IsSatisfiedBy(Order order)
        {
            return !String.IsNullOrEmpty(order.Username) && !String.IsNullOrWhiteSpace(order.Username);
        }
    }
}
