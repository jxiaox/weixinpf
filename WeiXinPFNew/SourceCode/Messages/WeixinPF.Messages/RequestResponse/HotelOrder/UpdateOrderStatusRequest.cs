﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeixinPF.Messages.RequestResponse.HotelOrder
{
    public class UpdateOrderStatusRequest
    {
        public int OrderId { get; set; }
        public int StatusId { get; set; }
    }
}
