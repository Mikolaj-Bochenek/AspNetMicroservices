using System;
using System.Collections.Generic;
using MediatR;
using Ordering.Application.Features.Orders.Queries.GetOrdersList;

namespace Ordering.Application.Features.Orders.Queries.GetOrderList
{
    public class GetOrdersListQuery : IRequest<List<OrdersVm>>
    {
        public GetOrdersListQuery(string userName)
        {
            UserName = userName ?? throw new ArgumentNullException(nameof(userName));
        }
        public string UserName { get; set; }
    }
}