using AutoMapper; 
using Microsoft.EntityFrameworkCore;
using ServernewRUB.BusinessLogic.Core.interfaces;
using ServernewRUB.BusinessLogic.Core.Models;
using ServernewRUB.DataAccess.Core.Interfaces.DbcContext;
using ServernewRUB.DataAccess.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using ServernewRUB.Shared.Exception;

namespace ServernewRUB.BusinessLogic.Serices
{
    public class UserService : IUserService
    {
        private readonly IMapper _mapper;
        private readonly IRubicContext _context;

        public UserService(IMapper mapper, IRubicContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }
        /// <summary>
        /// Авторизует пользователя в системе
        /// </summary>

        /// <param name="numberPrefix">Код страны телефона</param>
        /// <param name="PhoneNumber">Номер телефона </param>
        /// <param name="number">номер</param>
        /// <param name="password">пароль</param>
        /// <returns>Объект UserInformationBlo</returns>
        public async Task<UserInformationBlo> Auth(int numberPrefix, int PhoneNumber, int number, string password)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumberPrefix == numberPrefix && x.PhoneNumber == number && x.Password == password);

            if (user == null)
                throw new NoteFoundException("Неверный логин или пвроль");

            return await CovertToUserInformationBlo(user);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="phoneNumberPrefix"></param>
        /// <param name="number"></param>
        /// <returns>Объект UserInformationBlo</returns>
        public Task<bool> DoesExist(int phoneNumberPrefix, int number)
        {
            return _context.Users.AnyAsync(x => x.PhoneNumberPrefix == phoneNumberPrefix && x.PhoneNumber == number);

        }
        /// <summary>
        /// Добавление пользователя 
        /// </summary>
        /// <param name="userId">ID пользователя</param>
        /// <returns>Объект UserInformationBlo</returns>
        public async Task<UserInformationBlo> Get(int userId)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(x => x.id == userId);

            if (user == null)
                throw new NoteFoundException("ID не найден");

            return await CovertToUserInformationBlo(user);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="numberPrefix">Код номера страны</param>
        /// <param name="phoneNumber">Номер телефона</param>
        /// <param name="number">номер</param>
        /// <param name="password">пароль</param>
        /// <returns>Объект UserInformationBlo</returns>
        public async Task<UserInformationBlo> Registration(int numberPrefix, int phoneNumber, int number, string password)
        {
            UserRto newUser = new UserRto() { PhoneNumberPrefix = numberPrefix, PhoneNumber = number, Password = password };
            _context.Users.Add(newUser);

            await _context.SaveChangesAsync();
            return await CovertToUserInformationBlo(newUser);
        }
        /// <summary>
        /// Обновление данных 
        /// </summary>
        /// <param name="numberPrefix">Код номера страны</param>        /// <param name="PhoneNumber">номер телефона</param>
        /// <param name="number">номер</param>
        /// <param name="password">пароль</param> 
        /// <param name="userUpdateBlo">Пакет новой информацииб какой надо заменить </param>
        /// <returns>Объект UserInformationBlo</returns>
        public async Task<UserInformationBlo> Update(int numberPrefix, int PhoneNumber, int number, string password, UserUpdateBlo userUpdateBlo)
        {
            UserRto user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumberPrefix == numberPrefix && x.PhoneNumber == number && x.Password == password);

            if (user == null)
                throw new NoteFoundException("Пользователь не найден");

            if (userUpdateBlo.isBoy != null) user.isBoy = userUpdateBlo.isBoy;
            if (userUpdateBlo.password != null) user.password = userUpdateBlo.password;
            if (userUpdateBlo.FirstName != null) user.FirstName = userUpdateBlo.FirstName;
            if (userUpdateBlo.LastName != null) user.LastName = userUpdateBlo.LastName;
            if (userUpdateBlo.Patronymic != null) user.Patronymic = userUpdateBlo.Patronymic;
            if (userUpdateBlo.Birthday != null) user.Birthday = userUpdateBlo.Birthday;
            if (userUpdateBlo.AvatarUrl != null) user.AvatarUrl = userUpdateBlo.AvatarUrl;

            await _context.SaveChangesAsync();

            return await CovertToUserInformationBlo(user);
        }
        /// <summary>
        /// Конвертирует из UserRto в UserInformationBlo
        /// </summary>
        /// <param name="userRto">объект UserRto</param>
        /// <returns>Объект UserInformationBlo</returns>
        private async Task<UserInformationBlo> CovertToUserInformationBlo(UserRto userRto)
        {
            if (userRto == null)
                throw new ArgumentNullException(nameof(UserRto));

            UserInformationBlo userInformationBlo = _mapper.Map<UserInformationBlo>(userRto);

            return userInformationBlo;
        }
    }
}
