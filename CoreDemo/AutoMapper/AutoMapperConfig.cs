using AutoMapper;
using CoreDemo.Data.Entity;
using CoreDemo.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.AutoMapper
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {
            CreateMap<TestModel, TblTest>().ReverseMap();
            CreateMap<TestDetailCustomModel, TblTestDetail>().ReverseMap();
        }
    }
}
