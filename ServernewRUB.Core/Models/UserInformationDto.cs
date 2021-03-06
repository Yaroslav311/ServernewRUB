using System;
using System.Collections.Generic;
using System.Text;

namespace ServernewRUB.Core.Models
{
    public class UserInformationDto
    {
        public int id { get; set; }
        public bool isBoy { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string Patronymic { get; set; }
        public string AvatarUrl { get; set; }
    }
}
