﻿using System;
using System.Collections.Generic;

namespace FlowersStore.Core.CoreModels
{
    public class Basket
    {
        public Guid BasketId { get; set; }

        public Guid Id { get; set; }

        public string Name { get; set; }

        public string UserName { get; set; }

        public User User { get; set; }

        public DateTime DateCreated { get; set; }

        public IEnumerable<ShopingCart> ShopingCarts { get; set; }
    }
}