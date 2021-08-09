﻿using System;

namespace FlowersStore.Core.CoreModels
{
    public class ShopingCart
    {
        public Guid CartId { get; set; }

        public Guid BasketId { get; set; }

        public Guid ProductId { get; set; }

        public int Quantity { get; set; } = 0;

        public DateTime DateCreated { get; set; }

        public virtual Basket Basket { get; set; }

        public virtual Product Product { get; set; }
    }
}