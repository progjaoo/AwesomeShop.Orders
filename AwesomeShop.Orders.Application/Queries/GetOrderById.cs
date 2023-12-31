using AwesomeShop.Orders.Application.Dto.ViewModels;
using MediatR;

namespace AwesomeShop.Orders.Application.Queries
{
    public class GetOrderById : IRequest<OrderViewModel>
    {
        public GetOrderById(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; private set; }
    }
}