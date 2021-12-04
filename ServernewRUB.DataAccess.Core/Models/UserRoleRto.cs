using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ServernewRUB.DataAccess.Core.Models
{
    public class UserRoleRto
    {
        [Key] public int Id { get; set; }
        public string Name { get; set; }
    }
}
