using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using WeixinPF.Common;
using WeixinPF.Hotel.Plugins.Service.Application.Service;
using WeixinPF.Hotel.Plugins.Service.Handler.Base;
using WeixinPF.Messages.RequestResponse;
using WeixinPF.Messages.RequestResponse.RefundOrder.Dtos;

namespace WeixinPF.Hotel.Plugins.Service.Handler.RefundOrder
{
    public class GetRefundOrderServiceHandler : BaseHandler, IHandleMessages<GetRefundOrderRequest>
    {
        private readonly IBus _bus;

        public GetRefundOrderServiceHandler(IBus bus)
        {
            _bus = bus;
        }
        public void Handle(GetRefundOrderRequest message)
        {
            var service = new RefundOrderService();
            var order = service.GetModel(o=>o.OrderId==message.OrderId&&o.HotelId==message.HotelId);

            _bus.Reply(new GetRefundOrderResponse(){ RefundOrder = order.MapTo<RefundOrderDto>() });
        }
    }
}
