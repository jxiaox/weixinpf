using System;

namespace WeixinPF.Messages.RequestResponse.RefundOrder.Dtos
{
    public class RefundOrderDto
    {
        public int Id { get; set; }

        public int OrderId { get; set; }
        public int HotelId { get; set; }
        public string Openid { get; set; }
        public int Wid { get; set; }
        public int Roomid { get; set; }
        public DateTime RefundTime { get; set; }
        public double RefundAmount { get; set; }
        public int OperateUser { get; set; }
        public string Remarks { get; set; }
        public string RefundCode { get; set; }
    }
}
