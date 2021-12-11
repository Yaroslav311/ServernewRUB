using System;
using System.Collections.Generic;
using System.Text;

namespace ServernewRUB.BusinessLogic.Core.Models
{
    public class UserUpdateBlo
    {
        public int id { get; set; }
        public bool isBoy { get; set; }
        public string  password { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string AvatarUrl { get; set; }
    }
}
