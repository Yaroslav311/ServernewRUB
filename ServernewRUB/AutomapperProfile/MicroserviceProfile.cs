using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using ServernewRUB.BusinessLogic.Core.Models;
using ServernewRUB.Core.Models;

namespace ServernewRUB.AutomapperProfile
{
    public class MicroserviceProfile : Profile
    {
        public MicroserviceProfile()
        {
            CreateMap<UserInformationBlo, UserInformationDto>();
        }
    }
}
