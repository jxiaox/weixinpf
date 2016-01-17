using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;
using WeixinPF.Common.Enum;
using WeixinPF.Hotel.Plugins.Service.Application.Service;
using WeixinPF.Hotel.Plugins.Service.Models;
using WeixinPF.Messages.RequestResponse;
using WeixinPF.Messages.RequestResponse.Dtos;
using WeixinPF.Messages.RequestResponse.HotelOrder;

namespace WeixinPF.Hotel.Plugins.Service.Handler.Order
{
    public class UpdateOrderStatusHandler : IHandleMessages<UpdateOrderStatusRequest>
    {
        private readonly IBus _bus;

        public UpdateOrderStatusHandler(IBus bus)
        {
            this._bus = bus;
        }
        public void Handle(UpdateOrderStatusRequest message)
        {
            Console.WriteLine("Receive UpdateOrderStatusRequest MessageNumber is :OrderID{0} with status{1}", message.OrderId,message.StatusId);

            var response = new OperateIsSuccessResponse();
            var service = new HotelOrderService();
            try
            {
                var order = service.GetModel(message.OrderId);
                var statusDict = HotelStatusManager.OrderStatus.GetStatusDict(message.StatusId);
                if (order!=null)
                {
                    response.Success = service.Update(message.OrderId,
                        statusDict.ToString());
                }
                else
                {
                    response.Success = false;
                }
            }
            catch
            {
                response.Success = false;
            }

            _bus.Reply(response);
        }

      
    }
}
