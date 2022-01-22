using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ServernewRUB.DataAccess.Core.Models
{
    public class UserRto
    {
        [Key] public int id { get; set; }
        public bool isBoy { get; set; }
        [Required] public int PhoneNumberPrefix { get; set; }
        [Required] public int PhoneNumber { get; set; }
        [Required, MinLength(7)] public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public string password { get; set; }
        public DateTimeOffset Birthday { get; set; }
        public string AvatarUrl { get; set; }
        public string Introduction { get; set; }

        [NotMapped]
        public string GetFullName
        {
            get => LastName + " " + FirstName + " " + Patronymic;
        }
    }
}
