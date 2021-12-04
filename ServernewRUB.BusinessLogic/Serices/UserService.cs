using AutoMapper;
using ServernewRUB.BusinessLogic.Core.interfaces;
using ServernewRUB.BusinessLogic.Core.Models;
using ServernewRUB.DataAccess.Core.Interfaces.DbcContext;
using ServernewRUB.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServernewRUB.BusinessLogic.Serices
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRubicContext context;

        public UserService(IMapper mapper, IRubicContext context)
        {
            this._mapper = mapper;
            this.context = context;
        }

        public Task<UserInformationBlo> Auth(int phoneNumberPrefix, int phoneNumber, int password)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DoesExist(int phoneNumberPrefix, int phoneNumber)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Get(int UserId)
        {
            throw new NotImplementedException();
        }

        public Task<UserInformationBlo> Registration(int phoneNumberPrefix, int phoneNumber, int password)
        {
            throw new NotImplementedException();
        }

        public Task<UserUpdateBlo> Update(int phoneNumberPrefix, int phoneNumber, int password, UserUpdateBlo userUserUpdateBlo)
        {
            throw new NotImplementedException();
        }

        private async Task<UserInformationBlo> CovertToUserInformationBlo(UserRto userRto)
        {
            if (userRto == null)
                throw new ArgumentNullException(nameof(UserRto));

           UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
