using ServernewRUB.BusinessLogic.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServernewRUB.BusinessLogic.Core.interfaces
{
    public interface IUserService
    {
        Task<UserInformationBlo> Auth(int numberPrefix, int PhoneNumber, int number, string password);
        Task<UserInformationBlo> Registration(int numberPrefix, int phoneNumber, int number, string password);
        Task<UserInformationBlo> Get(int userId);
        Task<UserInformationBlo> Update(int numberPrefix, int PhoneNumber, int number, string password, UserUpdateBlo userUpdateBlo);
        Task<bool> DoesExist(int phoneNumberPrefix, int number);
    }
}
