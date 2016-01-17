using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeixinPF.Messages.RequestResponse
{
    public class GetRefundOrderRequest
    {
        public int OrderId { get; set; }
        public int HotelId { get; set; }
    }
}
