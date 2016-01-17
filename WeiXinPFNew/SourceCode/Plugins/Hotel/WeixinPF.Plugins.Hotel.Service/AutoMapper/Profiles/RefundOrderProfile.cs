using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using WeixinPF.Hotel.Plugins.Service.Models;
using WeixinPF.Messages.RequestResponse.RefundOrder.Dtos;

namespace WeixinPF.Hotel.Plugins.Service.AutoMapper.Profiles
{
    public class RefundOrderProfile : Profile
    {
        protected override void Configure()
        {
            Mapper.CreateMap<RefundOrder, RefundOrderDto>()
                //.ForMember(des => des.Id, source => source.MapFrom(s => s.Id))
                //.ForMember(des => des.OrderId, source => source.MapFrom(s => s.OrderId))
                //.ForMember(des => des.HotelId, source => source.MapFrom(s => s.HotelId))
                //.ForMember(des => des.Openid, source => source.MapFrom(s => s.OpendId))
                //.ForMember(des => des.OperateUser, source => source.MapFrom(s => s.OperateUser))
                //.ForMember(des => des.RefundAmount, source => source.MapFrom(s => s.RefundAmount))

                ;


            Mapper.CreateMap<RefundOrderDto, RefundOrder>()
                //.ForMember(des => des.Id, source => source.MapFrom(s => s.Id))
                ;

        }
    }
}
