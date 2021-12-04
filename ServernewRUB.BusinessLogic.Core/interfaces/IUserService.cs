using ServernewRUB.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServernewRUB.BusinessLogic.Core.interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> Auth(int phoneNumberPrefix, int phoneNumber, int password);
        Task<UserInformationBlo> Registration(int phoneNumberPrefix, int phoneNumber, int password);
        Task<UserInformationBlo> Get(int UserId);
        Task<UserUpdateBlo> Update(int phoneNumberPrefix, int phoneNumber, int password, UserUpdateBlo userUserUpdateBlo);
        Task<bool> DoesExist(int phoneNumberPrefix, int phoneNumber);
    }
}
