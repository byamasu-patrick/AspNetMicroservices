﻿using Ordering.Application.Features.Commands.CheckoutOrder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Features.Queries.GetOrdersList
{
    public class OrdersVm
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal ShippingPrice { get; set; }
        public decimal TotalWeight { get; set; }
        public List<OrderingShoppingCartItem> Products { get; set; }

        // BillingAddress
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string NationalId { get; set; }
        public string CourierName { get; set; }

        public string PhysicalAddress { get; set; }

        public string PaymentMethod { get; set; }

        public string OrderStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastModifiedDate { get; set; }
    }
}
