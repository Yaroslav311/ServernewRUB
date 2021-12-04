using AutoMapper;
using ServernewRUB.BusinessLogic.Core.Models;
using ServernewRUB.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServernewRUB.BusinessLogic.AutoMapperProfile
{
    public class BusinessLogicProfile : Profile
    {
        public BusinessLogicProfile()
        {
            CreateMap<UserRto, UserInformationBlo>()
                .ForMember(x => x.id, x => x.MapFrom(m => m.id))
                .ForMember(x => x.isBoy, x => x.MapFrom(m => m.isBoy))
                .ForMember(x => x.FirstName, x => x.MapFrom(m => m.FirstName))
                .ForMember(x => x.LastName, x => x.MapFrom(m => m.LastName))
                .ForMember(x => x.Patronymic, x => x.MapFrom(m => m.Patronymic))
                .ForMember(x => x.Birthday, x => x.MapFrom(m => m.Birthday))
                .ForMember(x => x.AvatarUrl, x => x.MapFrom(m => m.AvatarUrl));

            CreateMap<UserRto, UserUpdateBlo>()
                .ForMember(x => x.id, x => x.MapFrom(m => m.id))
                .ForMember(x => x.isBoy, x => x.MapFrom(m => m.isBoy))
                .ForMember(x => x.password, x => x.MapFrom(m => m.password))
                .ForMember(x => x.FirstName, x => x.MapFrom(m => m.FirstName))
                .ForMember(x => x.LastName, x => x.MapFrom(m => m.LastName))
                .ForMember(x => x.Patronymic, x => x.MapFrom(m => m.Patronymic))
                .ForMember(x => x.Birthday, x => x.MapFrom(m => m.Birthday))
                .ForMember(x => x.AvatarUrl, x => x.MapFrom(m => m.AvatarUrl));
        }
    }
}
